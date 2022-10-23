// 14. Напишите программу, которая пригимает а вход число и проверяет, кратно ли оно одновременно 7 и 23.
Console.WriteLine("Введите первое число:");
int number1 = int.Parse(Console.ReadLine()!);
if (number1 % 7 == 0 && number1 % 23 == 0)
{
    Console.WriteLine("Число кратно 7 и 23");
}
else
Console.WriteLine("не кратно 7 и 23");