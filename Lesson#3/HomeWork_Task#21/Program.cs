//Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Write("x0: ");
double x0 = double.Parse(Console.ReadLine()!);
Console.Write("y0: ");
double y0 = double.Parse(Console.ReadLine()!);
Console.Write("z0: ");
double z0 = double.Parse(Console.ReadLine()!);
Console.Write("x1: ");
double x1 = double.Parse(Console.ReadLine()!);
Console.Write("y1: ");
double y1 = double.Parse(Console.ReadLine()!);
Console.Write("z1: ");
double z1 = double.Parse(Console.ReadLine()!);

double Vector(double x0, double y0, double z0, double x1, double y1, double z1)
{
    double X = x0 - x1;
    double Y = y0 - y1;
    double Z = z0 - z1;
    double result = Math.Round(Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2)), 2);
    return result;
}

Console.WriteLine($"A({x0}, {y0}, {z0}); B({x1}, {y1}, {z1}) -> {Vector(x0, y0, z0, x1, y1, z1)}");