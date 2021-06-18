using System;
using Data.AbstractClasses;

namespace Data.Entities
{
    public class Shift : EntityBase
    {
        public int DriverId { get; set; }
        public virtual Driver Driver { get; set; }
        
        public int BusId { get; set; }
        public virtual Bus Bus { get; set; }
        
        public int RouteId { get; set; }
        public virtual Route Route { get; set; }
        
        public DateTime Date { get; set; }
    }
}