﻿
// Напишете метод, който пресмята сумата на две цели положителни цели числа. Числата са представени като масив от цифрите си, като последната цифра (единиците) са записани в масива под индекс 0. Направете така, че метода да работи за числа с дължина до 10 000 цифри.

using System;


namespace Zad._8
{
    class Program
    {
        
         static void Main()
         {
                int length;
                int[] Array1 = new int[10000];
                int[] Array2 = new int[10000];

                Console.Write(" Въведете I-во Число: ");
                String s1 = Console.ReadLine();
                length = s1.Length;

                  for (int i = 0; i < s1.Length; i++)
                  {
                    Array1[i] = Convert.ToInt32(s1.Substring(s1.Length - 1 - i, 1));
                  }

               Console.Write(" Въведете II-ро Число: ");
               String s2 = Console.ReadLine();

                  if (s2.Length > length)
                  {
                    length = s2.Length;
                  }

                  for (int i = 0; i < s2.Length; i++)
                  {
                    Array2[i] = Convert.ToInt32(s2.Substring(s2.Length - 1 - i, 1));
                  }

                  for (int i = 0; i < length; i++)
                  {
                    Array1[i] += Array2[i];

                    if (Array1[i] >= 10)
                    {
                        Array1[i] -= 10;
                        Array1[i + 1]++;
                    }
                  }

                  if (Array1[length] == 1)
                  {
                    length++;
                  }

                Console.WriteLine();
                Console.Write(" Резултта е: ");

                  for (int i = 0; i < length; i++)
                  {
                    Console.Write(Array1[length - 1 - i]);
                  }

                Console.ReadLine();
         }
         
    }
}
