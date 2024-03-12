using resume_api.Models;
using Microsoft.EntityFrameworkCore;

namespace resume_api.Data
{
  public class ResumeContext : DbContext
  {
    public ResumeContext(DbContextOptions<ResumeContext> options) : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);            
    }

    public DbSet<User> Users { get; set; }
    
    /*
    public DbSet<Job> Jobs { get; set; }
    public DbSet<Duty> Duties { get; set; }
    public DbSet<Degree> Degrees { get; set; }
    public DbSet<Certification> Certifications { get; set; }    
    public DbSet<Award> Awards { get; set; }
    public DbSet<Role> Roles { get; set; }    
    public DbSet<Link> Links { get; set; }
    public DbSet<Skill> Skills { get; set; }
    */
  }
}

