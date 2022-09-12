System.Console.WriteLine("Введите номер четверти");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
   System.Console.WriteLine("x > 0 и y > 0");
}
else if (number == 2)
{
   System.Console.WriteLine("x < 0 и y > 0");
}
else if (number == 3)
{
   System.Console.WriteLine("x < 0 и y < 0");
}
else if (number == 4)
{
   System.Console.WriteLine("x > 0 и y < 0");
}
else
{
   System.Console.WriteLine("Номер четверти задан неправильно");
}