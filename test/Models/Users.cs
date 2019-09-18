using System;
using System.Collections.Generic;

namespace test.Models
{
    public partial class Users
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
        public string EmailAddr { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool IsActive { get; set; }
    }
}
