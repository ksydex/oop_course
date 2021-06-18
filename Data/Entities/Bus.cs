using System.Collections.Generic;
using Data.AbstractClasses;

namespace Data.Entities
{
    public class Bus : EntityBase
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int Places { get; set; }
        public int YearOfIssue { get; set; }
        public string Plate { get; set; }
        
        public virtual IList<Shift> Shifts { get; set; }
    }
}