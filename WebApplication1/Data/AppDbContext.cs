using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using WebApplication1.Models;

namespace WebApplication1.Data
{

       public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseImage> CourseImages { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
