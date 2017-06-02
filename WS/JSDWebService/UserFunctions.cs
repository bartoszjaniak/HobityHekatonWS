﻿using JSDWebService.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.Entity.Core.EntityClient;
using System.Linq;
using System.Web;
using System.Web.Services.Protocols;

namespace JSDWebService
{
    public class UserFunctions : SoapHeader
    {


        public static bool AuthorizeUser(User usr)
        {
            using (DataBaseContext db = new DataBaseContext())
            {
                var U = db.User.Find(usr.login);
                if (U == null) return false;
                if (usr.password == U.password) return true;
            }
            return false;
        }

        public static bool AddUser(User usr)
        {
            using (var db = new DataBaseContext())
            {
                User U = db.User.Find(usr.login);
                if (U == null)
                {
                    db.User.Add(usr);
                    db.SaveChanges();
                    return true;
                }                    
            }
            return false;
        }

        public static bool ChangePassword(User usr, string newPassword){
            using (var db = new DataBaseContext())
            {
                User U = db.User.Find(usr.login);
                if (U == null)
                {
                    U.password = newPassword;
                    db.SaveChanges();
                    return true;
                }
            }
            return false;
        }

    }
 
}