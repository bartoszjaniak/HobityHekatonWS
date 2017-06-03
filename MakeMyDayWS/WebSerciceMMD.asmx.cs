using JSDWebService;
using JSDWebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace MakeMyDayWS
{
    /// <summary>
    /// Summary description for WebSerciceMMD
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebSerciceMMD : System.Web.Services.WebService
    {
        //Variables
        public Account UserAccount { get; set; }

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
        public bool AddUser(Account usr)
        {
            return UserFunctions.AddUser(usr);
        }

        #endregion

        [WebMethod]
        public bool Test1()
        {
            return Functions.Test();
        }

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


        //Zakładanie wydarzenia
        [WebMethod]
        [SoapHeader("UserAccount")]
        public bool CreateEvent(Event Event)
        {
            if (UserFunctions.AuthorizeUser(UserAccount))
                return Functions.Test();
            else
                return false;
        }




    }
}
