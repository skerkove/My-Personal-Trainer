using EntityProject.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityProject.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users {get; set;}
        public DbSet<Muscle> Muscles {get; set;}
        public DbSet<Workout> Workouts {get; set;}
        public DbSet<Train> Trains {get; set;}
        public DbSet<Plan> Plans {get;set;}
    }
}