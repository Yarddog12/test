﻿using System;
using System.Collections.Generic;

namespace test.Models
{
    public partial class Organization
    {
        public int Id { get; set; }
        public string Organization1 { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool IsActive { get; set; }
    }
}
