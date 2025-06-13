using kolos2.DTOs;
using kolos2.Models;
using Microsoft.EntityFrameworkCore;

namespace kolos2.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Nursery> Nurseries { get; set; }
    public DbSet<ResponsibleDto> SchoolInfoDtos { get; set; }
    public DbSet<Tree_Species> TreeSpeciesEnumerable { get; set; }
    public DbSet<Responsible>  Responsibles{ get; set; }
}