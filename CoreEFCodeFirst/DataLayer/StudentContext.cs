using Microsoft.EntityFrameworkCore;

namespace CoreEFCodeFirst.DataLayer
{
    public class StudentContext : DbContext
    {

        public StudentContext() { }

        public StudentContext(DbContextOptions<StudentContext> options) : base(options) { }

        public DbSet<Models.Student> Students { get; set; }

    }
}
