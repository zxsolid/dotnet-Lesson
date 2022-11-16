//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

int[] GetArray(int size, int minValue, int maxValue) 
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int GetLot(int[] array)
{
    int count = 0;
    foreach(int el in array)
    {
        count += el%2 == 0 ? 1 : 0;
    }
    return count;
}

int[] array = GetArray(5, 100, 1000);
Console.WriteLine(String.Join(",", array));
Console.WriteLine($"Количество четных чисел: {String.Join(", ", GetLot(array))}");