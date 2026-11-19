using Greencare.Models;
using Microsoft.EntityFrameworkCore;

namespace Greencare.Data;

public class GreencareContext : DbContext
{
    public GreencareContext(DbContextOptions<GreencareContext> options)
        : base(options)
    {
    }

    public DbSet<Customer> Customers { get; set; } = default!;
    public DbSet<Employee> Employees { get; set; } = default!;
    public DbSet<Service> Services { get; set; } = default!;
    public DbSet<Property> Properties { get; set; } = default!;
    public DbSet<Appointment> Appointments { get; set; } = default!;
    public DbSet<Invoice> Invoices { get; set; } = default!;
}