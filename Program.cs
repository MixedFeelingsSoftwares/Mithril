using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mithril.Core.Menus;
using Mithril.Core.Options;

namespace Mithril
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.Title = "Mithril - Hotel Booking (Main Menu) (Unregistered)";
                new string[] {
                    "Search Customer",
                    "Register new Customer",
                    "Room Booking",
                    "Details",
                    "Checkout details"
                }.CreateOption(new Action<int, string>((num, opt) =>
                {
                    Debug.WriteLine(opt);
                    Console.Clear();
                    MenuMaker.CreateCustomerMenu();
                    Console.Title = $"Mithril - Hotel Booking ({opt}) (Unregistered)";
                    Console.ReadLine();
                }));
            }
        }
    }
}
