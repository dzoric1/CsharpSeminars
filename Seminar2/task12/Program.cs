﻿// Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму. Если число 1 не кратно числу 2, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 % number2 == 0)
{
   Console.WriteLine("Первое число кратно второму");
}
else
{
   System.Console.WriteLine("Первое число не кратно второму," + " остаток = " + (number1 % number2));
}