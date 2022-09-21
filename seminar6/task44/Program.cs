int ReadNumber(string message)
{
   Console.WriteLine(message);
   return Convert.ToInt32(Console.ReadLine());
}

void FibonachiN(int n)
{
   int number1 = 0;
   int number2 = 1;
   int temp = 0;
   System.Console.Write(number1 + " ");
   System.Console.Write(number2 + " ");

   for (int i = 2; i < n; i++)
   {
      temp = number1 + number2;
      System.Console.Write(temp + " ");
      number1 = number2;
      number2 = temp;

   }
}

int N = ReadNumber("Введите число");
FibonachiN(N);