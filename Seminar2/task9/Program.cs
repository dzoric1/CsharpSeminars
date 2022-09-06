// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

Random rand = new Random();
int number = rand.Next(10, 100);
System.Console.WriteLine($"Сгенерировалось случайное число {number}");
int digit2 = number % 10;
int digit1 = number / 10;
// System.Console.WriteLine(digit1);
// System.Console.WriteLine(digit2);
if (digit1 > digit2)
{
   System.Console.WriteLine($"{digit1} больше {digit2}");
}
else
{
   System.Console.WriteLine($"{digit2} больше {digit1}");
}