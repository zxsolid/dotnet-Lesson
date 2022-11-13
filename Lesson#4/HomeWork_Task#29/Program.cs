// 29. Задает массив из 8 элементов, заполняемых пользователем и выводит его на экран

Console.Clear();

int[] GetArr2()
{
    int[] arr=new int[8];
    for (int i = 0; i < 8; i++)
    {
        Console.WriteLine($"Введите элемент №{i+1}");
        arr[i]=int.Parse(Console.ReadLine()!);
    }
    return arr;
}

Console.WriteLine("Введите 8 чисел чтобы заполнить массив");
Console.WriteLine(String.Join(",", GetArr2()));