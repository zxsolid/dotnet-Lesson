// 50. Напишите программу, которая на вход принимает число и ищет его в двумерном массиве. 
//Программа должна возвращать значение позиции (номер строки и столбца) этого элемента или же указание, что такого элемента нет

Console.Clear();

int[,] GetAr(int m, int n, int mi = -5, int ma = 5) // Создание и вывод матрицы. Диапазон задан по умолчанию
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

string FindNum(int num, int[,] inArray) // Поиск элемента в массиве
{
    string res = "Такого элемента нет";

    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (inArray[i, j] == num)
            {
                return res = $"Адрес искомого элемента: строка {i + 1}, столбец {j + 1}";

            }
        }
    }
    return res;
}

Console.WriteLine("Введите количество строк матрицы");
int x = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов матрицы");
int y = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите искомый элемент");
int z = int.Parse(Console.ReadLine()!);

int[,] Array = GetAr(x, y);

Console.WriteLine(FindNum(z, Array));