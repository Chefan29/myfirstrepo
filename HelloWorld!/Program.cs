using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет, Мир!");
            Console.ReadLine();
            Console.Write("Calculator. Enter your value of parameter: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nYour parameter in square {a*a}. ");
            Console.ReadLine();
        }
    }
}
