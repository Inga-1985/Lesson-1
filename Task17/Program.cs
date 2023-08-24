// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Напишите программу, которая принимает на вход
// 1. принимает на вход координаты точки (X и Y), 
// 2. причём X ≠ 0 и Y ≠ 0 и
// 3. выдает номер четверти плоскости, в которой находится эта точка.

int Quarter(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}

Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int xCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordinate = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(xCoordinate, yCoordinate);
string result = quarter > 0
? $"Указанные координаты соответствуют четверти -> {quarter}"
: "Введены некорректные данные";

Console.WriteLine(result);

