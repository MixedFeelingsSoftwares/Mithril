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

        public static void CreateCustomerMenu()
        {
            var customer = new Data.DataManager.Customer(2);
            customer.GenerateRandom();

            Console.WriteLine("\n####### Customer ######\n");
            foreach (var prop in typeof(Data.DataManager.Customer).GetProperties())
            {
                for (int i = 0; i < customer.GetPeople.Count; i++)
                {
                    Console.WriteLine("\n####### Person ######\n");
                    foreach (var prop2 in typeof(Data.DataManager.Customer.Person).GetProperties())
                    {
                        Console.WriteLine($"{prop2.Name}: {prop2.GetValue(customer.GetPeople[i])}");
                    }
                    foreach (var field in typeof(Data.DataManager.Customer.Person).GetFields())
                    {
                        Console.WriteLine($"{field.Name}: {field.GetValue(customer.GetPeople[i])}");
                    }
                }
            }
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
