﻿using System;
namespace c_scharp_companies.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public Employee? Employee { get; set; }
        public int? EmploeeId { get; set; }
    }
}
