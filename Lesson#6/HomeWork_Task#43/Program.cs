// 43. Найти точку пересечения двух прямых, заданных уравнениями y=k1*x+b1, y=k2*x+b2. Значения переменных задаются пользователем

Console.Clear();

void printNo()
{
    Console.WriteLine("Прямые параллельны или совпадают");
}

double[] CrossPoint(int[] a, int[] b)
{
    if ((a[1] == b[1]) || (a[0] == b[0] && a[1] == b[1]))
    {
        printNo();
        return new double[0];
    }
    double[] res = new double[2];
    res[0] = Convert.ToDouble(a[0] - b[0]) / (b[1] - a[1]);
    res[1] = Convert.ToDouble(b[1]*res[0]+b[0]);
    return res;
}


Console.WriteLine("Введите через запятую b1 и k1 для первой прямой");
int[] first = Console.ReadLine()!.Split(',').Select(int.Parse).ToArray();

Console.WriteLine("Введите через запятую b2 и k2 для второй прямой");
int[] second = Console.ReadLine()!.Split(',').Select(int.Parse).ToArray();

Console.WriteLine($"({String.Join(';', CrossPoint(first, second))})");