// Задача 10. Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();

Console.WriteLine("Введите трехзначное число:");
int number = int.Parse(Console.ReadLine()!);

int result = number/10%10;

Console.WriteLine($"В числе {number} вторая цифра - это {result}");