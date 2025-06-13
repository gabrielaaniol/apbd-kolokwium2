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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Responsible>()
            .HasKey(pm => new { pm.BatchId, pm.Employee });
        
        modelBuilder.Entity<Responsible>()
            //.HasOne(pm => pm.Employee)
            //.WithMany(p => p.Responsible)
            //.HasForeignKey(pm => pm.Employee)
            ;
        
        modelBuilder.Entity<Responsible>()  
            .HasOne(pm => pm.Seedling_Batch)
           // .WithMany(m => m.Responsible)
            //.HasForeignKey(pm => pm.BatchId)
            ;

        modelBuilder.Entity<Seedling_Batch>()
            .HasOne(m => m.Tree_Species)
           // .WithMany(t => t.Seedling_Batches)
            //.HasForeignKey(m => m.SpeciesId)
            ;

        modelBuilder.Entity<Seedling_Batch>()
            .HasOne(m => m.Nursery)
            .WithMany(mp => mp.Seedlings)
            .HasForeignKey(m => m.NurseryId);
    }
}