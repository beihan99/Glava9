
//  Напишете метод, който проверява дали елемент, намиращ се на дадена позиция от масив, е по-голям, или съответно по-малък от двата му съседа. Тествайте метода дали работи коректно.

using System;


namespace Zad._5
{
    class Program
    {
        static  void Srav(int[] arr, int n)
        {
            if (arr[n] > arr[n - 1] && arr[n] > arr[n + 1])
            {
                Console.WriteLine(" Eлемент номер {0} = {1}",n,arr[n]);
                Console.WriteLine(" {0} > {1} и {0} > {2}", arr[n], arr[n-1], arr[n+1]);
            }
            else if (arr[n]> arr[n-1] && arr[n] < arr[n + 1])
            {
                Console.WriteLine(" Eлемент номер {0} = {1}", n, arr[n]);
                Console.WriteLine(" {0} > {1} и {0} < {2}", arr[n], arr[n - 1], arr[n + 1]);
            }
            else if (arr[n] < arr[n - 1] && arr[n] > arr[n + 1])
            {
                Console.WriteLine(" Eлемент номер {0} = {1}", n, arr[n]);
                Console.WriteLine(" {0} < {1} и {0} > {2}", arr[n], arr[n - 1], arr[n + 1]);
            }
            else if (arr[n] < arr[n - 1] && arr[n] < arr[n + 1])
            {
                Console.WriteLine(" Eлемент номер {0} = {1}", n, arr[n]);
                Console.WriteLine(" {0} < {1} и {0} < {2}", arr[n], arr[n - 1], arr[n + 1]);
            }
            else
            {
                Console.WriteLine(" Невалиден елемент !");
            }
        }
        static void Main()
        {
            Console.Write(" Дължина на масива: ");
            int dl = int.Parse(Console.ReadLine());
            int[] arr = new int[dl];

              for (int i = 0; i < arr.Length; i++)
              {
                Console.Write(" Въведете елемент {0}: ", i);
                arr[i] = int.Parse(Console.ReadLine());
              }
            Console.Write(" Номер на елемент за сравнение: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Srav(arr,n);
            
        }
    }
}
