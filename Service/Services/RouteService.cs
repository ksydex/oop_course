using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Repository.Interfaces;
using Service.AbstractClasses;
using Service.Filters;
using Service.Interfaces;

namespace Service.Services
{
    public class RouteService : ServiceBase<Route, EmptyFilter>, IRouteService
    {
        public RouteService(IRepository<Route> repository, DbContext dbContext) : base(repository, dbContext)
        {
        }
    }
}