using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameAndAge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter years: ");
            int years = int.Parse(Console.ReadLine());
            Console.WriteLine("My name is {0}. I'm {1} years old and after {2} years i will be {3} years old.", name, age, years, age + years);
        }
    }
}
