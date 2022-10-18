//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее. 
//Console.Clear();
Console.WriteLine("Введите первое число:");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите первое число:");
int number2 = int.Parse(Console.ReadLine()!);
if (number1 < number2)
{
    Console.WriteLine($"Число {number1} меньше, чем {number2}");
}
else if (number1 > number2 )
{
    Console.WriteLine($"Число {number2} меньше, чем {number1}");
}
else
{
    Console.WriteLine("Числа равны");
}
