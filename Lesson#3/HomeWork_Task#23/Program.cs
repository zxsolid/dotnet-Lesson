//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

String GetPow(int value)
{
    String pows = "";
    for (int i = 1; i < value; i++)
    {
        pows += ($"{Math.Pow(i, 3)}, ").ToString();
    }
    pows += Math.Pow(N, 3).ToString();
    return pows;
}

Console.WriteLine(GetPow(N));