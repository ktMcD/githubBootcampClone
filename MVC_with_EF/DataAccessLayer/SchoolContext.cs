using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using MVC_with_EF.Models;

namespace MVC_with_EF.DataAccessLayer
{
    public class SchoolContext : DbContext
    {
        public SchoolContext()
        {

        }
        public SchoolContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<StudentViewModel> Students { get; set; }
        public DbSet<CourseViewModel> Courses { get; set; }
        public DbSet<EnrollmentViewModel> Enrollments { get; set; }

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
