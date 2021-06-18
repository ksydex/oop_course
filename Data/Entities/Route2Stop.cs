using Data.AbstractClasses;

namespace Data.Entities
{
    public class Route2Stop : EntityBase
    {
        public int RouteId { get; set; }
        public virtual Route Route { get; set; }
        
        public int StopId { get; set; }
        public virtual Stop Stop { get; set; }
    }
}