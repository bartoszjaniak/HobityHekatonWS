using MakeMyDayWS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JSDWebService.Models
{
    public class Invite
    {
        [Key]
        public int ID { get; set; }
        public Event Event { get; set; }
        public User Invited { get; set; }
        public bool Answer { get; set; }
    }
}