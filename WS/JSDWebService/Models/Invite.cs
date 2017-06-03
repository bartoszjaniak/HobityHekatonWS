using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JSDWebService.Models
{
    public class Invite
    {
        public Event Event { get; set; }
        public User Invited { get; set; }
        public bool Answer { get; set; }
    }
}