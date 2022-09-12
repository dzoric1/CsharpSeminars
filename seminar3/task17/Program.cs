// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

System.Console.WriteLine("Введите координату точки по X");
int x = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату точки по y");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
   System.Console.WriteLine("Точка находится в первой координатной четверти");
}

else if (x < 0 && y > 0)
{
   System.Console.WriteLine("Точка находится во второй координатной четверти");
}

else if (x < 0 && y < 0)
{
   System.Console.WriteLine("Точка находится в третьей координатной четверти");
}

else if (x > 0 && y < 0)
{
   System.Console.WriteLine("Точка находится в четвертой координатной четверти");
}
else
{
   System.Console.WriteLine("Введена нулевая координата по Х или Y");
}