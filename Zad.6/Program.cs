
//  Напишете метод, който връща позицията на първия елемент на масив, който е по-голям от двата свои съседи едновременно, или -1, ако няма такъв елемент.

using System;


namespace Zad._6
{
    class Program
    {
        static int number = int.MinValue;

        static void CompareNumber(int[] arr)
        {
            for (int i = 1; i < arr.Length - 1; i++)
                if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                {
                    number = arr[i];
                    break;
                }
        }

        static void Main(string[] args)
        {
            Console.Write(" Дължина на масива: ");
            int dl = int.Parse(Console.ReadLine());

            int[] arr = new int[dl];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" Въведете елемент {0}: ", i+1);
                arr[i] = int.Parse(Console.ReadLine());
            }

            CompareNumber(arr);

            if (number == int.MinValue) Console.WriteLine("-1");
            else Console.WriteLine(" По-голям от съседните е {0}", number);
        }
    }
}
