// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] array = GetArray(20, 100, 999);

int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}
Console.WriteLine("Массив:");
Console.Write("[ ");
foreach (int value in array)
{
    Console.Write(value + "  ");
}
Console.WriteLine("]");

int Search()
{
    int count = 0;
    foreach (int value in array)
    {
        if (value % 2 == 0) count++;
    }
    return count;
}
Console.WriteLine();

Console.WriteLine($"Количество четных чисел в массиве: {Search()}");