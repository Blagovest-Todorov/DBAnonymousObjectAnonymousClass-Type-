using System;
using System.Collections.Generic;

namespace SoftUni2.Models
{
    public partial class Drivers
    {
        public Drivers()
        {
            Cars = new HashSet<Cars>();
        }

        public int DriverId { get; set; }
        public string DriverName { get; set; }

        public virtual ICollection<Cars> Cars { get; set; }
    }
}
