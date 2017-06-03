using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JSDWebService.Models;
using MakeMyDayWS.Models;

namespace JSDWebService
{
    public class DataBaseInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<DataBaseContext>
    {
        /// <summary>
        /// Specjalna metoda, która jest wywoływana raz po przebudowaniu bazy danych.
        /// Założenie jest, że baza jest pusta, więc trzeba ją wypełnić początkowymi danymi.
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(DataBaseContext context)
        {          
            Account userAccount = new Account() { login = "test", password = "test" };
            User user1 = new User() { Nick = "test" };
            User user2 = new User() { Nick = "test2"};

            Event ev = new Event() { Name = "Piwko", StartDate = DateTime.Now, Orgaznizer = user1, Longitude = 123.123, Latitude = 21.12312, Icon = 1, Description = "Piwko nad Odrą", IsPublic = false, TimeInHours = 3 };
            Friends fr = new Friends() { User1 = user1, User2 = user2 };
            Invite inv = new Invite() { Event = ev, Invited = user2, Answer = true };
            context.User.Add(userAccount);
            context.Event.Add(ev);
            context.SaveChanges();
            base.Seed(context);
        }
    }
}