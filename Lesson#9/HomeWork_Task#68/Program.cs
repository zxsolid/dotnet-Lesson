// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.Clear();

int RotateAkkermann(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0 && m != 0) return RotateAkkermann(m - 1, 1);
    return RotateAkkermann(m - 1, RotateAkkermann(m, n - 1));
}

Console.WriteLine("Введите m");
int firstNum = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите n");
int secondNum = int.Parse(Console.ReadLine()!);

Console.Write(RotateAkkermann(firstNum, secondNum));
