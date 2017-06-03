using JSDWebService;
using JSDWebService.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSDWebService
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext()
            : base("MakeMyDay")
        {
            Database.SetInitializer<DataBaseContext>(new DataBaseInitializer());
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Account> User { get; set; }
        public DbSet<Event> Event { get; set; }
        public DbSet<Friends> Friends { get; set; }
        public DbSet<Invite> Invite { get; set; }

    }
}
