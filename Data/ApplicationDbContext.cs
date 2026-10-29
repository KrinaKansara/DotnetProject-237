using CrimeRecordsSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace CrimeRecordsSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        // THIS LINE IS CRITICAL: It must accept DbContextOptions<ApplicationDbContext>
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
        }

        public DbSet<Officer> Officers { get; set; }
        public DbSet<FIR> FIRs { get; set; }
        public DbSet<Criminal> Criminals { get; set; }
    }
}