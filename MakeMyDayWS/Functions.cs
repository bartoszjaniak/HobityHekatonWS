using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Web;

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

    }
}
