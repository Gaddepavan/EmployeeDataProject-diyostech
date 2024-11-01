using Employedataproject.Models;
using Microsoft.EntityFrameworkCore;

namespace Employedataproject.Dbconnect
{
    public class Contextclass:DbContext
    {
        public Contextclass(DbContextOptions<Contextclass> options):base(options) { }
        public DbSet<Employee> emp { get; set; }

    }
}
