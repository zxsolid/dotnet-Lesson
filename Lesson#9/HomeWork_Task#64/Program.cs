// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
Console.Clear();

string PrintNums(int n = 8)
{
    if (n == 1) return n.ToString();
    return $"{n}, {PrintNums(n - 1)} ";
}



Console.WriteLine("Введите N");
int n = int.Parse(Console.ReadLine()!);

Console.Write(PrintNums(n));
