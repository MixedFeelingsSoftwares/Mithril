using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Mithril.Core.Options
{
    public static class OptionHelper
    {
        public static void CreateOption(this string[] options, Action<int, string> callback)
        {
            for (int i = 0; i < options.Length; i++)
            {
                string opt = options[i];
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write($"[{i + 1}]");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($" {opt}\n");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"Select Option [1 - {options.Length}]: ");
            Console.ForegroundColor = ConsoleColor.White;
            string key = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            if (Regex.IsMatch(key, "[1-9]"))
            {
                int num = -1;
                int.TryParse(key, out num);
                if (num != -1 && options.Length > num-1)
                {
                    callback(num-1, options[num-1]);
                }
            }
        }
    }
}
