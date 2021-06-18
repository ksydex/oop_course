using System.Linq;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Repository.Interfaces;
using Service.AbstractClasses;
using Service.Filters;
using Service.Interfaces;

namespace Service.Services
{
    public class ShiftService : ServiceBase<Shift, ShiftFilter>, IShiftService
    {
        public ShiftService(IRepository<Shift> repository, DbContext dbContext) : base(repository, dbContext)
        {
        }

        public override IQueryable<Shift> QueryableFiltered(IQueryable<Shift> q, ShiftFilter filter)
        {
            if (filter.BusId != null) q = q.Where(x => x.BusId == filter.BusId);
            if (filter.RouteId != null) q = q.Where(x => x.RouteId == filter.RouteId);
            if (filter.DriverId != null) q = q.Where(x => x.DriverId == filter.DriverId);
            return q;
        }
    }
}