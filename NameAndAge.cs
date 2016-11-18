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
            int newAge = age + 10;
            Console.WriteLine("My name is {0}. I'm {1} years old and after 10 years i will be {2} years old.", name, age, newAge);
        }
    }
}
