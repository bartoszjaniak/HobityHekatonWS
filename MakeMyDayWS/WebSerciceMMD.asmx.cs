
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
        public bool Login(Account account)
        {
            return UserFunctions.AuthorizeUser(account);
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

       


        //Zakładanie wydarzenia
        [WebMethod]
        public bool CreateEvent(Event Event)
        {
            return Functions.UtworzWydarzenie(Event);
        }

        //Wyświetlanie wydarzeń
        [WebMethod]
        public List<Event> ShowEvents(User user)
        {
            return Functions.WyswietlWydarzenia(user);
        }

        //Dodaj znajomego
        [WebMethod]
        public int AddFriend(User user, string nick)
        {
                return Functions.DodajZnajomego(user,nick);
        }

        //Pokaż liste znajomych

        //public List<User> ShowFriends(User user)
        //{
        //    return Functions.ZwrocListeZnajomych(user);
        //}
        [WebMethod]
        public string ShowFriends()
        {
            return Functions.test2();
        }




    }
}
