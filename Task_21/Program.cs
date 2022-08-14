// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

double DistanceBetweenCoordinates (double xa, double ya, double za, double xb, double yb, double zb)
{
    return Math.Sqrt(Math.Pow(xb-xa,2) + Math.Pow(yb-ya,2) + Math.Pow(zb-za,2));
}

Console.WriteLine("Введите значение координаты по оси x точки а: ");
double xa = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение координаты по оси y точки а: ");
double ya = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение координаты по оси z точки a: ");
double za = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение координаты по оси x точки b: ");
double xb = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение координаты по оси y точки b: ");
double yb = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение координаты по оси z точки b: ");
double zb = double.Parse(Console.ReadLine()!);

double distance = DistanceBetweenCoordinates(xa,ya,za,xb,yb,zb);
Console.WriteLine($"{distance:f2}");
