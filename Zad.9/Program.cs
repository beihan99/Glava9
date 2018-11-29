
//  Напишете метод, който намира най-големия елемент в част от масив. Използвайте метода за да сортирате възходящо/низходящо даден масив.

using System;


namespace Zad._9
{
    class Program
    {
        public static int GetMax(int[] array, int start, int end)
        {
            int maxNum = array[start];

            for (int i = start + 1; i < end; i++)
            {
                if (array[i] > maxNum) maxNum = array[i];
            }

            return maxNum;
        }

        public static void Main(string[] args)
        {
            Console.Write(" Дължина на масива: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" Въведете елемент {0}: ", i );
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Write(" Начало на интервала: ");
            int startIndex = Int32.Parse(Console.ReadLine());

            Console.Write(" Край на интервала: ");
            int endIndex = Int32.Parse(Console.ReadLine());

            Console.WriteLine(" Най-голяма стойност от интервала ({0}-{1} е {2}).", startIndex, endIndex, GetMax(arr, startIndex, endIndex));
        }
    }
}