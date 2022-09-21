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

void ReverseArray(int[] array)
{
   for (int i = 0; i < array.Length / 2; i++)
   {
      int temp = array[i];
      array[i] = array[array.Length - 1 - i];
      array[array.Length - 1 - i] = temp;
   }
}

int[] arr = GetArray(5, 0, 10);
System.Console.WriteLine($"Исходный массив = {string.Join(" ", arr)}");
ReverseArray(arr);
System.Console.WriteLine($"Развернутый массив = {string.Join(" ", arr)}");