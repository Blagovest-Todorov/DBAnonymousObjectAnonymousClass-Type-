using System;
using System.Collections.Generic;

namespace SoftUni2.Models
{
    public partial class Products
    {
        public Products()
        {
            Stock = new HashSet<Stock>();
        }

        public int BarcodeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Stock> Stock { get; set; }
    }
}
