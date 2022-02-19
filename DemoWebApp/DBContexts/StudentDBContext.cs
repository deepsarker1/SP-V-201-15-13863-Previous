using Microsoft.EntityFrameworkCore;
using DemoWebApp.Models;
namespace DemoWebApp.DBContexts
{
    public class StudentDBContext:DbContext
    {
        public StudentDBContext(DbContextOptions<StudentDBContext> options):base(options)
        {

        }

        public DbSet<Student> Student{ get; set; }

    }
}
