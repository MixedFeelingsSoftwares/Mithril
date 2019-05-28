using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mithril.Core.Menus
{
    public static class MenuMaker
    {
        public static void CreateMenu(this Dictionary<string, string> args, string title)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"###### {title.ToUpper()} ######\n");
            for (int i = 0; i < args.Count; i++)
            {
                var parameter = args.ElementAt(i);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write($"{parameter.Key}: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"{parameter.Value}\n");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Press ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("[ENTER]");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" To return");
        }

        public static void CreateBookingsMenu()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("First Name", "Erik");
            dict.Add("Last Name", "Olsson");
            dict.CreateMenu("Bookings");
        }
    }
}
