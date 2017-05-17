using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maximalny pocet ziskanych bodov: ");
            int maxPocet = int.Parse(Console.ReadLine());
            Console.WriteLine("Pocet ziskanych bodov: ");
            int ziskane = int.Parse(Console.ReadLine());
         
            if (ziskane >= maxPocet * 0.9) Console.WriteLine("Presiel si a mas 1.");
            else if (ziskane >= maxPocet * 0.75) Console.WriteLine("Presiel si a mas 2.");
            else if (ziskane >= maxPocet * 0.5) Console.WriteLine("Presiel si, ale mas 3.");
            else Console.WriteLine("Nepresiel si.");
            
            

            Console.ReadKey();
        }
    }
}