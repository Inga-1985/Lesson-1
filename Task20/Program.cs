// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

double FindDistance(int xA, int yA, int xB, int yB)
{
    return Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2));
}

Console.WriteLine("Введите координаты первой точки");
Console.Write("X: ");
int xCoordinateA = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordinateA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
Console.Write("X: ");
int xCoordinateB = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordinateB = Convert.ToInt32(Console.ReadLine());

double result = FindDistance(xCoordinateA, yCoordinateA, xCoordinateB, yCoordinateB);
Console.WriteLine($"Расстояние между точками -> {Math.Round(result, 2, MidpointRounding.ToZero)}");
