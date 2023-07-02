using System;
namespace c_scharp_companies.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public List<Employee> Employees { get; set; } = new List<Employee>();
}
}
