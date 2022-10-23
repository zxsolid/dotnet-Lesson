//Задача 13: Напишите программу, которая выводит третью цифру (справа налево) заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int number2 = 0;
if (number/100 > 0)
{
    number2 = number % 1000 / 100;
    Console.WriteLine(number2);
}
else 
{
    Console.WriteLine("Третьей цифры нет");
}