//16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);
if (number1 * number1 == number2 || number2 * number2 == number1)
{
    Console.Write("да");
}
else
    Console.Write("Нет");