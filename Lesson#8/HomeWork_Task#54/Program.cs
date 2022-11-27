//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Clear();

int[,] GetAr(int m, int n, int mi = 1, int ma = 10) // Создание матрицы. Диапазон задан по умолчанию
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

void PrintArr(int[,] inAr) // Печать двумерного массива
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

int[] SortOneString(int[] ar) // Сортировка одной строки
{
    int temp = 0;
    for (int j = 1; j < ar.Length; j++)
    {
        for (int i = 1; i < ar.Length; i++)
        {
            if (ar[i] > ar[i - 1])
            {
                temp = ar[i - 1];
                ar[i - 1] = ar[i];
                ar[i] = temp;
            }
        }
    }
    return ar;
}

int[,] SortTwoD(int[,] arr)
{
    int row = arr.GetLength(0);
    int col = arr.GetLength(1);
    int[,] res=new int[row, col];
    for (int i = 0; i < row; i++)
    {int[]temp=new int[col]; // Временный одномерный массив для хранения строчки. Сортируем её зависимым методом. Знаю, не айс =(
        for (int j = 0; j < col; j++)
        {
            temp[j]=arr[i, j];
        }
        for (int l = 0; l<col; l++){
            res[i,l]=SortOneString(temp)[l];
        }
    }
    return res;
}

Console.WriteLine("Введите количество строк");
int row = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов");
int col = int.Parse(Console.ReadLine()!);

int[,] Array = GetAr(row, col);
PrintArr(Array);
Console.WriteLine();
PrintArr(SortTwoD(Array));