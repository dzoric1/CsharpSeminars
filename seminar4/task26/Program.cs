﻿// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

System.Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int i = 0;

while (number > 0)
{
   number = number / 10;
   i++;
}
System.Console.WriteLine(i);