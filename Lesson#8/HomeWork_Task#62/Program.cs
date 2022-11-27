// Напишите программу, которая заполнит спирально массив 4 на 4.
int[,] FillArray(int row, int col)
{
    int[,] array = new int[row, col];
    int num = 1;
    int i = 0;
    int j = 0;

    while (num <= row * col)
    {
        array[i, j] = num;
        if (i <= j + 1 && i + j < row - 1) j++;
        else if (i < j && i + j >= row - 1) i++;
        else if (i >= j && i + j > row - 1) j--;
        else i--;

        num++;
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{String.Join(',', array[i, j])} ");
        }
        Console.WriteLine();
    }
}

int[,] array = FillArray(4, 4);
PrintArray(array);