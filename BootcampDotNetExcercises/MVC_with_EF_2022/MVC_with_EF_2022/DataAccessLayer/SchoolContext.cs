using Microsoft.EntityFrameworkCore;
using MVC_with_EF_2022.Models;

namespace MVC_with_EF_2022.DataAccessLayer
{
    public class SchoolContext: DbContext
    {
        public SchoolContext()
        {

        }
        public SchoolContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        private static IConfigurationRoot _configuration;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

                _configuration = builder.Build();
                string cnstr = _configuration.GetConnectionString("SchoolDb");
                optionsBuilder.UseSqlServer(cnstr);
            }
        }
    }
}

