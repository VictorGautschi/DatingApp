using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    /* DbContext is an important class in Entity Framework API. 
       It is a bridge between your domain or entity classes and the database. */
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options ) : base (options) {}

        public DbSet<Value> Values { get; set; } // Values will be become the table name when we scaffold our database
        public DbSet<User> Users { get; set; }
    }
}