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
            Lista.Add(new Event() { Description = "Testowe wydarzenie" });
            Lista.Add(new Event() { Description = "Testowe wydarzenie2" });
            return Lista;
        }



        public static int DodajZnajomego(string nick)
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

        public static List<User> ZwrocListe (int id)
        {

            
            return null;
        }

    }
}
