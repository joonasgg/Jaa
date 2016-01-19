using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int sum = 0;
            do
            {
                Console.Write("Please sir, enter a number");
                number = int.Parse(Console.ReadLine());
                sum += number;

            } while (number != 0);

            Console.WriteLine("Sum is:" + sum);
            Console.WriteLine("Thank you for playing.");
            Console.ReadLine();

        }
    }
}
