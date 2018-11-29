
//   Напишете метод, който отпечатва цифрите на дадено десетично число в обратен ред. Например 256, трябва да бъде отпечатано като 652.

using System;


namespace Zad._7
{
    class Program
    {
        public static string Reverse(string number)
        {
            char[] charArray = number.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static void Main(string[] args)
        {
            Console.Write(" Въведете число: ");
            string number = Console.ReadLine();

            Console.WriteLine(" Огледалното число е {0}",Reverse(number));
        }
    }
}