using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Repository.Interfaces;
using Service.AbstractClasses;
using Service.Filters;
using Service.Interfaces;

namespace Service.Services
{
    public class BusService : ServiceBase<Bus, EmptyFilter>, IBusService 
    {
        public BusService(IRepository<Bus> repository, DbContext dbContext) : base(repository, dbContext)
        {
        }
        
        
    }
}