using System;
using System.Collections.Generic;

namespace SoftUni2.Models
{
    public partial class AppUsers
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Pass { get; set; }
    }
}
