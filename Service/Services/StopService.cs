using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Repository.Interfaces;
using Service.AbstractClasses;
using Service.Filters;
using Service.Interfaces;

namespace Service.Services
{
    public class StopService : ServiceBase<Stop, EmptyFilter>, IStopService
    {
        public StopService(IRepository<Stop> repository, DbContext dbContext) : base(repository, dbContext)
        {
        }
    }
}