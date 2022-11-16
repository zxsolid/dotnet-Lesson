//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] GetArray(int size, double minValue, double maxValue) 
{
    double[] array = new double[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble() * (maxValue - minValue) + minValue;
    }
    return array;
}

double GetDifference(double[] array)
{
    double difference = array.First() > array.Last() 
                        ? array.First() - array.Last()
                        : array.Last() - array.First();
    return difference;
}

double[] array = GetArray(4, 1 , 100);
Console.WriteLine(String.Join("; ", array));
Console.WriteLine($"Разность первого и последнего элемента: {GetDifference(array)}");