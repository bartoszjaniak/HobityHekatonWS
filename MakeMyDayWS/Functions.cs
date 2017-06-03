using System;
using System.Collections.Generic;

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
            
            return Lista;
        }


        public static int DodajZnajomego(User user, string nick)
        {
            // 0 - Dodano znajomego
            // 1 - Użytkownik jest już na liście znajomych
            // 2 - Nie ma takiego użytkownika 
            return 0;
        }

        public static bool UtworzWydarzenie (Event wydarzenie)
        {  
            return true;
        }

        public static List<User> ZwrocListeZnajomych (User user)
        {
            List<User> Lista = new List<User>();
            Lista.Add(new User() { ID = 2, Nick = "Klakier" });
            Lista.Add(new User() { ID = 75, Nick = "Gamoń" });
            return null;
        }

    }
}
