//  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();

string FindMinString(int[,] ar)
{
    int stringNumber = 0; // Заводим переменную под номер строки 
    int minSum = 0; // Заводим переменную под сумму строки
    for (int i = 0; i < ar.GetLength(0); i++) // считаем сумму первой строки и запоминаем
    {
        minSum += ar[0, i];
    }
    for (int i = 1; i < ar.GetLength(0); i++) // Считаем сумму последующей строки и сравниваем с предыдущей. 
    {
        int temp = 0;

        for (int j = 0; j < ar.GetLength(1); j++)
        {
            temp += ar[i, j];
        }
        if (temp < minSum) { minSum = temp; stringNumber = i; } // Если меньше, перезаписываем переменную
    }

    return $"Номер строки с наименьшей суммой: {stringNumber + 1}";
}

int[,] GetAr(int m, int n, int mi = -10, int ma = 10) // Создание и вывод матрицы для сверки. Диапазон задан по умолчанию
{
    int[,] res = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = new Random().Next(mi, ma + 1);
        }
    }
    return res;
}

void PrintArr(int[,] inAr)
{
    for (int i = 0; i < inAr.GetLength(0); i++)
    {
        for (int j = 0; j < inAr.GetLength(1); j++)
        {
            Console.Write($"{inAr[i, j]} \t ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


Console.WriteLine("Введите количество строк массива");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов массива");
int b = int.Parse(Console.ReadLine()!);

int[,] array = GetAr(a, b);
PrintArr(array);

Console.WriteLine(FindMinString(array));

