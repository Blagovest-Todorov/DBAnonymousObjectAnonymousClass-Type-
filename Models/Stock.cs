using System;
using System.Collections.Generic;

namespace SoftUni2.Models
{
    public partial class Stock
    {
        public int Id { get; set; }
        public int? BarcodeId { get; set; }

        public virtual Products Barcode { get; set; }
    }
}
