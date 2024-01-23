using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijeljivost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double broj = 23;

            if (broj % 4 == 0 && broj % 6 == 0)
            {
                Console.Write("Broj je dijeljiv sa 4 i sa 6.");
            }
            else if (broj % 4 != 0 && broj % 6 != 0)
            {
                Console.Write("Broj nije dijeljiv ni sa 4 ni sa 6.");
            }
            else if (broj % 4 == 0)
            {
                Console.Write("Broj je dijeljiv sa 4. ");
            }
            else if (broj % 6 == 0)
            {
                Console.Write("Broj je dijeljiv sa 6.");
            }

            Console.ReadKey();
        }
    }
}
