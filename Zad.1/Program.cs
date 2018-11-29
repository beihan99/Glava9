
// Напишете метод, който при подадено име отпечатва в конзолата "Hello, <name>!" (например "Hello, Peter!"). Напишете програма, която тества този метод дали работи правилно.

using System;


namespace Zad._1
{
    class Program
    {
        static void name(string n)
        {
            Console.WriteLine(" Здравей, {0} !", n);
        }
        static void Main()
        {
            Console.Write(" Въведете име: ");
            string n = Console.ReadLine();
            name(n);
        }
    }
}
