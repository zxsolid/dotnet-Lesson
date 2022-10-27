//Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
int value = int.Parse(Console.ReadLine()!);

String GetNumber(int value)
{
    int firstNumber = value/10000;
    int secondNumber = value/1000%10;
    int fourNumber = value%100/10;
    int fiveNumber = value%10;
    if (firstNumber == fiveNumber && secondNumber == fourNumber)
    {
        return "да";
    }
    else
    {
        return "нет";
    }
}
Console.WriteLine($"{value} -> {GetNumber(value)}");