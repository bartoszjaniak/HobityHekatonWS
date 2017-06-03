using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Services.Protocols;

namespace JSDWebService.Models
{
    public class Account : SoapHeader
    {
        [Key]
        public int ID { get; set; }        
        public string login { get; set; }       
        public string password { get; set; }
    }
}