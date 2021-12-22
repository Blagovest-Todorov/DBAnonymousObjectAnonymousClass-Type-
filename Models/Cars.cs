using System;
using System.Collections.Generic;

namespace SoftUni2.Models
{
    public partial class Cars
    {
        public int CarId { get; set; }
        public int? DriverId { get; set; }

        public virtual Drivers Driver { get; set; }
    }
}
