using API_practice_2.Models;
using Microsoft.EntityFrameworkCore;

namespace API_practice_2.Data
{
    public class ApplicationDBContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public ApplicationDBContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public DbSet<University> Univeristies { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Speciality> Specialities { get; set; }
        public DbSet<Group> Groups {  get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_configuration.GetConnectionString("VPS"));
        }
    }
}
