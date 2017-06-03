using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.Entity.Core.EntityClient;
using System.Linq;
using System.Web;
using System.Web.Services.Protocols;

namespace MakeMyDayWS
{
    public class UserFunctions : SoapHeader
    {


        public static bool AuthorizeUser(Account usr)
        {
            using (DataBaseContext db = new DataBaseContext())
            {
                Account U = db.Account.Where(u=>u.login == usr.login).Select(u=>u).First();
                if (U == null) return false;
                if (usr.password == U.password) return true;
            }
            return false;
        }

        public static bool AddUser(Account usr)
        {
            using (var db = new DataBaseContext())
            {
                Account U = db.Account.Find(usr.login);
                if (U == null)
                {
                    usr.user = new User() { Nick = usr.login };
                    db.Account.Add(usr);
                    db.SaveChanges();
                    return true;
                }                    
            }
            return false;
        }

        public static bool ChangePassword(Account usr, string newPassword){
            using (var db = new DataBaseContext())
            {
                Account U = db.Account.Find(usr.login);
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