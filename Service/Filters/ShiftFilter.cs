using Service.Interfaces.Common;

namespace Service.Filters
{
    public class ShiftFilter : IEntityFilter
    {
        public int? BusId { get; set; }
        public int? RouteId { get; set; }
        public int? DriverId { get; set; }
    }
}