﻿// // Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу квадратов чисел от 1 до N.
// // 5 -> 1, 4, 9, 16, 25.
// // 2 -> 1,4

System.Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
   int i = 1;

   while (number >= i)
   {
      System.Console.Write(Math.Pow(i, 2) + " ");
      i++;
   }
}
else
{
   System.Console.WriteLine("Введите число больше нуля");
}