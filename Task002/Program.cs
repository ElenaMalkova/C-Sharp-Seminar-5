// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
int[] array = GetArray(4, 1, 9);


int[] GetArray(int size, int min, int max)
{
  int[] result = new int[size];

  for (int i = 0; i < size; i++)
  {
    result[i] = new Random().Next(min, max + 1);
  }
    Console.WriteLine("Массив: {0}{1}{2}", "[", String.Join(", ", result), "]");
  return result;
}

int SumOfOddNumbers(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i+=2)
    {
        sum += arr[i];
    }
    return sum;
}

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {SumOfOddNumbers(array)} ");

