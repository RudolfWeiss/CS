using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sk.rudolf.cs
{
    class Druhy
    {
        static void Main(string[] args)
        {
            int sucet = 0;
            for (int i = 0; i < 11; sucet += i++) Console.WriteLine(i);
            Console.WriteLine("sucet je " + sucet);
            float priemer = sucet / 10.0f;
            Console.WriteLine("priemer je "+priemer);
            Console.ReadKey();
        }
    }
}
