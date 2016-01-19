using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Anna sekunnit");
            number = int.Parse(Console.ReadLine());

            Console.WriteLine("Antamasi sekunttiaika voidaan ilmaista muodossa: " + number/600 + number/60);
        }
    }
}
