using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Repository.Interfaces;
using Service.AbstractClasses;
using Service.Filters;
using Service.Interfaces;

namespace Service.Services
{
    public class DriverService : ServiceBase<Driver, EmptyFilter>, IDriverService
    {
        public DriverService(IRepository<Driver> repository, DbContext dbContext) : base(repository, dbContext)
        {
        }
    }
}