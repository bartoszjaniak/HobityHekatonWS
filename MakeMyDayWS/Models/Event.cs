using MakeMyDayWS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JSDWebService.Models
{
    public class Event
    {
        [Key]
        public int ID { get; set; }
        public User Orgaznizer { get; set; }
        public int Icon { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public int TimeInHours { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string Adres { get; set; }
        public bool IsPublic { get; set; }        
    }
}