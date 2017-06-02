using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JSDWebService.Models;

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
          
            UserAccount userAccount = new UserAccount() { login = "test", password = "test" };

          


            context.SaveChanges();
            base.Seed(context);
        }
    }
}