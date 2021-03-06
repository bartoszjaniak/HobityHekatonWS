﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MakeMyDayWS
{
    public class Invite : DbSet
    {
        [Key]
        public int ID { get; set; }
        public Event Event { get; set; }
        public User Invited { get; set; }
        public bool Answer { get; set; }
    }
}