// 25. Принимает на вход два числа (А и В) и возводит А в степень В

Console.Clear();

int GetPow(int[] a)
{
    int result=1;
    for (int i =0; i<a[1]; i++){
        result*=a[0];
    }
    return result;
}

Console.WriteLine("Введите число и степень для возведения через пробел");


int[] clientData=Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

Console.WriteLine(GetPow(clientData));