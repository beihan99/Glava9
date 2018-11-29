
// Напишете метод, който връща английското наименование на послед­ната цифра от дадено число. Примери: за числото 512 отпечатва "two"; за числото 1024 – "four".

using System;


namespace Zad._3
{
    class Program
    {
        static void NumName(string n)
        {
            switch (n[n.Length - 1])
            {
                case '1': Console.WriteLine(" One"); break;
                case '2': Console.WriteLine(" Two"); break;
                case '3': Console.WriteLine(" Three"); break;
                case '4': Console.WriteLine(" Four"); break;
                case '5': Console.WriteLine(" Five"); break;
                case '6': Console.WriteLine(" Six"); break;
                case '7': Console.WriteLine(" Seven"); break;
                case '8': Console.WriteLine(" Eight"); break;
                case '9': Console.WriteLine(" Nine"); break;
                case '0': Console.WriteLine(" Zero"); break;
                default: Console.WriteLine(" Невалидна стойност !"); break;
            }
        }

        static void Main()
        {
            Console.Write(" Въведете число: ");
            string n = Console.ReadLine();

            NumName(n);
        }
    }
}
        
