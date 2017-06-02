using JSDWebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace JSDWebService
{
    /// <summary>
    /// Summary description for AdminService
    /// </summary>
    [WebService(Namespace = "http://dosomething.pl/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class EventService : WebService
    {
        //Variables
        public User UserAccount { get; set; }

        #region USER
        //logowanie
        [WebMethod]
        [SoapHeader("UserAccount")]
        public bool Login()
        {
            return UserFunctions.AuthorizeUser(UserAccount);
        }

        //Rejestracja
        [WebMethod]
        public bool AddUser(User usr)
        {
            return UserFunctions.AddUser(usr);
        }

        #endregion


        //Metoda z autoryzacją
        [WebMethod]
        [SoapHeader("UserAccount")]
        public bool Test()
        {
            if (UserFunctions.AuthorizeUser(UserAccount))
                return Functions.Test();
            else
                return false;
        }
    }
}
