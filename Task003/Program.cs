// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

int[] array = GetArray(10, 1, 99);

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

int SearchMinMax(int[] arr)
{
    int max = arr[0];
    int min = arr[0];

    foreach (int value in arr)
    {
        if (value > max)
        {
            max = value;
        }
        if (value < min)
        {
            min = value;
        }
    }
    int result = max - min;
    return result;
}

Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {SearchMinMax(array)}");