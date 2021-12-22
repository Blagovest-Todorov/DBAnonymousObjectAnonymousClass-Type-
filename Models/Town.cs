using System;
using System.Collections.Generic;

namespace SoftUni2.Models
{
    public partial class Town
    {
        public Town()
        {
            Address = new HashSet<Address>();
        }

        public int TownId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Address> Address { get; set; }
    }
}
