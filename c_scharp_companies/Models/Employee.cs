using System;
namespace c_scharp_companies.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public Company? Company { get; set; }
        public int? CompanyId { get; set; }

        public List<Address> Addresses { get; set; } = new List<Address>();
    }
}
