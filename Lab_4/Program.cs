using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give me your favorite number! ");
            int userInput = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <= userInput)
            {

                Console.WriteLine("{0,10}{1,10}{2,10}", "number ", "square ", "cube ");
                Console.WriteLine("{0}", i++);
                Console.WriteLine("{0,10}{1,10}{2,10}", i, i * i, i * i * i);
                i++;
            }
            Console.WriteLine();
        }
    }
}
