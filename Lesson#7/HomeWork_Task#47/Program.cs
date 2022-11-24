// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Clear();

double[,] GetArray(int rows, int cols, int minValue, int maxValue) // Метод создает двумерный массив вещественных чисел.
{
    double[,] res = new double[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            double k = Convert.ToDouble(new Random().Next(minValue, maxValue + 1));
            res[i, j] = Math.Round(new Random().NextDouble() * (k), 1);
        }
    }
    return res;
}


void PrintArr(double[,] arr) // Печать матрицы
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} \t");
        }
        Console.WriteLine();
    }

}

Console.WriteLine("Введите количество строк матрицы");
int x = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов матрицы");
int y = int.Parse(Console.ReadLine()!);

double[,] array = GetArray(x, y, -10, 10); // Диапазон случайных чисел жестко задан

PrintArr(array);