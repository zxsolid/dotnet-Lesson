//Задача "со звездочкой": Разобраться с алгоритмом сортировки методом пузырька. Реализовать невозрастающую сторировку.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int[] array = GetArray(10, 0, 40);
Console.WriteLine(String.Join(",", array));

void toSwap(int first, int second)
{
    int i = array[first];
    array[first] = array[second];
    array[second] = i;
}

int[] SortedArray(int[] array)
{
    for (int j = array.Length - 1; j >= 1; j--)
    {
        for (int i = 0; i < j; i++)
        {
            if (array[i] < array[i + 1])
            {
                toSwap(i, i + 1);
            }
        }
    }
    return array;
}

Console.WriteLine(String.Join(", ",SortedArray(array)));