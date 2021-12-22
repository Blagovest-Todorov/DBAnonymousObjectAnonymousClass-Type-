using System;
using System.Collections.Generic;

namespace SoftUni2.Models
{
    public partial class Logs
    {
        public int LogId { get; set; }
        public int? AccountId { get; set; }
        public decimal? OldSum { get; set; }
        public decimal? NewSum { get; set; }
    }
}
