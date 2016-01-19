using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku;
            Console.Write("Minkä ikäinen olet > ");
            luku = int.Parse(Console.ReadLine());
            if (luku < 18)
            {
                Console.WriteLine("Olet alaikäinen!");
            }
            else {
                if (luku > 18 && luku < 65)
                {
                    Console.WriteLine("Olet aikuinen!");
                }
                else
                {
                    Console.WriteLine("Olet seniori!");
                }
            }
            
        }
    }
}
