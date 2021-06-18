using System;
using System.Collections.Generic;
using System.Linq;
using Data.AbstractClasses;

namespace Data.Entities
{
    public class Driver : EntityBase
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateBirthday { get; set; }
        
        public virtual IList<Shift> Shifts { get; set; }

        public string Name =>
            $"{LastName} {FirstName.FirstOrDefault()}.{MiddleName.FirstOrDefault()}";
    }
}