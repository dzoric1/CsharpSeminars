// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

Random rand = new Random();
int number = rand.Next(100, 1000);
System.Console.WriteLine($"Сгенерировалось случайное число {number}");
int digit2 = number % 10;
int digit1 = number / 100;

System.Console.WriteLine($"Число без второлй цифры {digit1}{digit2}");


