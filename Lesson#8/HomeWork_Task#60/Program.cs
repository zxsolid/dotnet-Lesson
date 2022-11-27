// ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Console.Clear();

int[] RandomNums(int mi = 10, int ma = 100)
{
    int[] mass = new int[ma-mi];
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i]=(i + mi);
    }
    for (int j = mass.Length - 1; j >= 1; j--)
    {
        int u = new Random().Next(j + 1);
        int temp = mass[u];
        mass[u] = mass[j];
        mass[j] = temp;
    }
    return mass;
}

int[,,] GetAr(int m, int n, int k, int[] ar) // Создание куба.
{
    int c = 0;
    int[,,] res = new int[m, n, k];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int l = 0; l < k; l++)
            {

                res[i, j, l] = ar[c];
                c++;


            }
        }
    }
    return res;
}

void PrintArr(int[,,] inAr) // Вывод в консоль в том порядке, который приведен в задании
{
    for (int i = 0; i < inAr.GetLength(0); i++)
    {
        for (int j = 0; j < inAr.GetLength(1); j++)
        {
            for (int l = 0; l < inAr.GetLength(2); l++)
            { Console.Write($"{inAr[j, l, i]}({j},{l},{i}) \t "); }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("Введите длину первого измерения куба");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите длину второго измерения куба");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите длину третьего измерения куба");
int c = int.Parse(Console.ReadLine()!);

int[] massRandom = RandomNums();



int[,,] array = GetAr(a, b, c, massRandom);
PrintArr(array);