
//   Създайте метод GetMax() с два целочислени (int) параметъра, който връща по-голямото от двете числа. Напишете програма, която прочита три цели числа от конзолата и отпечатва най-голямото от тях, изпол­звайки метода GetMax().

using System;


namespace Zad._2
{
    class Program
    {
        static double GetMax(int n1, int n2)
        {
            double x = Math.Max(n1,n2);
            return x; 
        }
        static void Main()
        {
            Console.Write(" Въведете число 1: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write(" Въведете число 2: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write(" Въведете число 3: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(" Най-голямото число е {0}", Math.Max(GetMax(a, b), GetMax(a, c)));
        }
    }
}