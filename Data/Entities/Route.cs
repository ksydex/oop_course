using System.Collections;
using System.Collections.Generic;
using Data.AbstractClasses;

namespace Data.Entities
{
    public class Route : EntityBase
    {
        public string Name { get; set; }
        public double Cost { get; set; }
        public double Length { get; set; }

        public virtual IList<Shift> Shifts { get; set; }
        public virtual IList<Route2Stop> Route2Stops { get; set; }
    }
}