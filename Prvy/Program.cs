using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sk.rudolf.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte Mesiac = byte.Parse(Console.ReadLine());
            if (Mesiac < 3 || Mesiac == 12)
            {
                Console.WriteLine("Zima");
            }
            else if (Mesiac < 6) Console.WriteLine("Jar");
            else if (Mesiac < 9) Console.WriteLine("Leto");
            else if (Mesiac <= 11) Console.WriteLine("Jesen");
            else Console.WriteLine("Vela");

            Console.ReadKey();
        }
    }
}
