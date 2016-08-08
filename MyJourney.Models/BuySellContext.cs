using System.Collections.Generic;
using System.Data.Entity;

namespace MyJourney.Models
{
    public class BuySellContext : DbContext
    {
        public BuySellContext() : base("BuySellContext")
        {
            
        }

        public DbSet<Category> Category { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Advertisement> Advertisement { get; set; }
        public DbSet<VisitorLog> VisitorLog { get; set; }
    }
}
