using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using c_scharp_companies.Models;

namespace c_scharp_companies.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<c_scharp_companies.Models.Joke> Joke { get; set; } = default!;
    public DbSet<c_scharp_companies.Models.Company> Company { get; set; } = default!;
    public DbSet<c_scharp_companies.Models.Address> Address { get; set; } = default!;
    public DbSet<c_scharp_companies.Models.Employee> Employee { get; set; } = default!;
}

