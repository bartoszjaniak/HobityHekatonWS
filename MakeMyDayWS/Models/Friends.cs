using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JSDWebService.Models
{
    public class Friends
    {
        [Key]
        public int ID { get; set; }
        public User User1 { get; set; }
        public User User2 { get; set; }
    }
}