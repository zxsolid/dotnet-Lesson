// 52. Задать двумерный массив из целых чисел. Найти среднее арифметическое в каждом столбце.

Console.Clear();

int[,] GetAr(int m, int n, int mi = -10, int ma = 10) // Создание и вывод матрицы для сверки. Диапазон задан по умолчанию
{
    int[,] res = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = new Random().Next(mi, ma + 1);
            Console.Write($"{res[i, j]} \t");
        }
        Console.WriteLine();
    }
    return res;
}

void GetMediemAr(int[,] ar) // Вывод средних арифметических
{
    for (int i = 0; i < ar.GetLength(1); i++)
    {
        double res = 0;
        for (int j = 0; j < ar.GetLength(0); j++)
        {
            res += ar[j, i];
        }
        res /= ar.GetLength(0);
        Console.WriteLine($"Среднее арифметическое столбца {i + 1} равно {Math.Round(res, 1)}");
    }
}

Console.WriteLine("Введите количество строк матрицы");
int x = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов матрицы");
int y = int.Parse(Console.ReadLine()!);

int[,] Array = GetAr(x, y); // Создание матрицы
GetMediemAr(Array); // вывод средих арифметических столбцов