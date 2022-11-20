// 41. Пользователь вводит с клавиутары М чисел. Посчитать, сколько чисел больше 0

Console.Clear();

int CountPos(int[] arr)
{
    int cnt = 0;
    foreach (int el in arr)
    {
        cnt += el > 0 ? 1 : 0;
    }
    return cnt;
}

Console.WriteLine("Введите масив чисел через пробел");
Console.WriteLine(CountPos(Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray()));