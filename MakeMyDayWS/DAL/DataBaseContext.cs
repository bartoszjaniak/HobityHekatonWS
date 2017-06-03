using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeMyDayWS
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext()
            : base("MakeMyDay")
        {
            Database.SetInitializer<DataBaseContext>(new DataBaseInitializer());
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Account> Account { get; set; }

        public DbSet<User> User { get; set; }
        public DbSet<Event> Event { get; set; }
        public DbSet<Friends> Friends { get; set; }
        public DbSet<Invite> Invite { get; set; }

    }
}
