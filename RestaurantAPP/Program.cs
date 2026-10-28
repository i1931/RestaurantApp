using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> menu = new Stack<string>();
            for (int i = 0; i < 5; i++) 

            {
                Console.WriteLine("กรอกชื่อเมนู: ");
                string name = Console.ReadLine();
                menu.Push(name);
            }

            Console.WriteLine("\nGet menu Stack: ");
            while (menu.Count > 0)
            {
                Console.WriteLine(menu.Pop());
            }

            Console.ReadKey();
        }
    }
}
