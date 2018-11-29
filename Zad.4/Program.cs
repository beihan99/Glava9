
// Напишете метод, който намира колко пъти дадено число се среща в даден масив. Напишете програма, която проверява дали този метод работи правилно.

using System;


namespace Zad._4
{
    class Program
    {
        static int CounN(int n, int[] arr)
        {
            int count = 0;

              for (int i = 0; i < arr.Length; i++)
              {
                if (n == arr[i]) count++;
              }
             return count;
        }

        static void Main()
        {
            Console.Write(" Дължина на масива: ");
            int dl = int.Parse(Console.ReadLine());

            int[] arr = new int[dl];

              for (int i = 0; i < arr.Length; i++)
              {
                Console.Write(" Въведете елемент {0}: ", i+1);
                arr[i] = int.Parse(Console.ReadLine());
              }

            Console.Write(" Число за търсене: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(" {0} се среща {1} пъти в масива !", n, CounN(n, arr));
        }
    }
}