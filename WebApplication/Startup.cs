using Data;
using Data.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Repository.AbstractClasses;
using Repository.Interfaces;
using Service.Interfaces;
using Service.Services;

namespace WebApplication
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            
            services.AddDbContext<ApplicationContext>(options =>
            {
                var connect = Configuration.GetConnectionString("Default");
                options.UseLazyLoadingProxies();
                options.UseNpgsql(connect, x => x.MigrationsAssembly(nameof(WebApplication)));
            });
            
            // to help repos find DbContext since actual type is ApplicationContext
            services.AddScoped<DbContext, ApplicationContext>();
            services.AddScoped(typeof(IRepository<>), typeof(RepositoryBase<>));

            services.AddScoped<IBusService, BusService>();
            services.AddScoped<IRouteService, RouteService>();
            services.AddScoped<IDriverService, DriverService>();
            services.AddScoped<IShiftService, ShiftService>();
            services.AddScoped<IStopService, StopService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
