// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] GetArray(int size, int leftRange, int rightRange)
{
   int[] arr = new int[size];
   Random rand = new Random();
   for (int i = 0; i < size; i++)
   {
      arr[i] = rand.Next(leftRange, rightRange + 1);
   }
   return arr;
}

(int, int) GetPositiveAndNegativeSums(int[] arr)
{
   int sumP = 0;
   int sumN = 0;

   for (int i = 0; i < arr.Length; i++)
   {
      if (arr[i] > 0)
      {
         sumP += arr[i];
      }
      else
      {
         sumN += arr[i];
      }
   }
   return (sumP, sumN);
}

Random rand = new Random();
int randomSize = rand.Next(5, 10);
int[] array = GetArray(randomSize, -100, 999);
System.Console.WriteLine(string.Join(", ", array));
(int sumPositive, int sumNegative) = GetPositiveAndNegativeSums(array);
System.Console.WriteLine($"Сумма положительных элементов = {sumPositive}, отрицательных элементов = {sumNegative}");