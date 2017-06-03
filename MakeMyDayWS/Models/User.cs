﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MakeMyDayWS.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        public string Nick { get; set; } 
    }
}