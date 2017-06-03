using System;
using System.Collections.Generic;
using System.Linq;

namespace MakeMyDayWS
{
    static public class Functions
    {
        
        public static bool Test()
        {
            return true;
        }

       
        public static List<Event> WyswietlWydarzenia(User user){
            
            List<Event> Lista = new List<Event>();
            Lista.Add(new Event() { Description = "Testowe wydarzenie", Latitude = 123.3123, Longitude = 12.123, Icon = 1, IsPublic = true, Orgaznizer = new User() { Nick = "asdasd" }, StartDate = DateTime.Now, Name = "Ognisko", TimeInHours = 1 });
            Lista.Add(new Event() { Description = "Testowe wydarzenie", Latitude = 12.3123, Longitude = 123.123, Icon = 1, IsPublic = true, Orgaznizer = new User() { Nick = "asdasesdfd" }, StartDate = DateTime.Now, Name = "Grill", TimeInHours = 1 });

            List<Event> EventList = new List<Event>();

            using(DataBaseContext db = new DataBaseContext())
            {
                var Invites = db.Invite.Where(u => u.Invited == user).Select(u => u.Event.ID);
                foreach(var item in Invites)
                {
                    EventList.Add(db.Event.Where(u => u.ID == item).Select(u => u).First());
                }
            }

            return EventList;
        }


        public static int DodajZnajomego(User user, string nick)
        {

            using (DataBaseContext db = new DataBaseContext())
            {
                var PotencialFriend = db.User.Where(u => u.Nick == nick).Select(u => u).First();
                if(PotencialFriend == null) return 2;
                var Friends = db.Friends.Where(u => u.User1 == user && u.User2 == PotencialFriend).Where(u => u.User2 == user && u.User1 == PotencialFriend).Select(u => u);
                if (Friends != null) return 1;
                db.Friends.Add(new Friends() { User1 = user, User2 = PotencialFriend });
                db.SaveChanges();
                return 0;
            }

                // 0 - Dodano znajomego
                // 1 - Użytkownik jest już na liście znajomych
                // 2 - Nie ma takiego użytkownika 
                // 3 - Inny błąd
                return 3;
        }

        public static bool UtworzWydarzenie (Event wydarzenie)
        {
            using (DataBaseContext db = new DataBaseContext())
            {
                db.Event.Add(wydarzenie);
                db.SaveChanges();
                return true;
            }
        }

        public static List<User> ZwrocListeZnajomych (User user)
        {
            
            using (DataBaseContext db = new DataBaseContext())
            {
                List<User> ListaZnajomych = db.Friends.Where(u => u.User1 == user).Select(u => u.User2).ToList();
                foreach (var a in db.Friends.Where(u => u.User2 == user).Select(u => u.User1).ToList())
                    ListaZnajomych.Add(a);
                return ListaZnajomych;
            }

            List<User> Lista = new List<User>();
            Lista.Add(new User() { ID = 2, Nick = "Klakier" });
            Lista.Add(new User() { ID = 75, Nick = "Gamoń" });
            return null;

        }

    }
}
