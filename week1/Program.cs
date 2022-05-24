// See https://aka.ms/new-console-template for more information

using System;

namespace week1
{
    class program {
        static void Main(string[] args) {
            Console.WriteLine();
            Console.Write("What is your first name? ");
            string first = Console.ReadLine();

            Console.WriteLine();
            Console.Write("What is your last name? ");
            string last = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine($"Your name is {last}, {first} {last}");
            Console.WriteLine();
        }
    }
}
