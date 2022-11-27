//  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.Clear();

int[,] GetAr(int m, int n, int mi = 1, int ma = 10) // Создание и вывод матрицы для сверки. Диапазон задан по умолчанию
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

int[,] MultMatrix(int[,] ar1, int[,] ar2)
{
    int[,] res = new int[ar1.GetLength(0), ar2.GetLength(1)];
    for (int i = 0; i < ar1.GetLength(0); i++)
    {
        for (int j = 0; j < ar2.GetLength(1); j++)
        {
            res[i, j] = 0;
            for (int l = 0; l < ar1.GetLength(1); l++)
            {
                res[i, j] += ar1[i, l] * ar2[l, j];
            }
        }
    }
    return res;
}

Console.WriteLine("Введите количество строк первой матрицы");
int a1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов первой матрицы");
int b1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов второй матрицы");
int a2 = b1;
int b2 = int.Parse(Console.ReadLine()!);

int[,] matrix1 = GetAr(a1, b1);
PrintArr(matrix1);
int[,] matrix2 = GetAr(a2, b2);
PrintArr(matrix2);
int[,] resMatrix = MultMatrix(matrix1, matrix2);
PrintArr(resMatrix);