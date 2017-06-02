﻿using JSDWebService;
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
            : base("MojaBazia2")
        {
            Database.SetInitializer<DataBaseContext>(new DataBaseInitializer());
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<UserAccount> UserAccount { get; set; }
    }
}
