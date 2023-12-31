﻿﻿// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] CrossPoint(double k1, double b1, double k2, double b2)
{
    double[] pos = new double[2];
    var x = (b2 - b1) / (k1 - k2);
    var y = k1 * x + b1;
    pos[0] = x;
    pos[1] = y;
    return pos;
}

double[] InputeLinesData()
{
    Console.Write("Введите k1: ");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите b1: ");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите k2: ");
    double k2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите b2: ");
    double b2 = Convert.ToDouble(Console.ReadLine());
    double[] pos = CrossPoint(k1, b1, k2, b2);
    return pos;
}

void PrintPosition(double[] pos)
{
    Console.Write("Точка пересечения: (");
    for (int i = 0; i < pos.Length; i++)
    {
        if (i < pos.Length - 1) Console.Write($"{pos[i]}, ");
        else Console.Write($"{pos[i]}");
    }
    Console.Write(")");
}

double[] position = InputeLinesData();
PrintPosition(position);



// // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// double FunctionX(int b1, int k1, int b2, int k2)
// {
//     double x = (b2 - b1) / (k1 - k2);
//     return x;
// }

// double FunctionY(int b2, int k2, double x)
// {
//     double y = (k2 * x) + b2;
//     return y;
// }

// Console.Write("Введите b1: ");
// int b1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите k1: ");
// int k1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите b2: ");
// int b2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите k2: ");
// int k2 = Convert.ToInt32(Console.ReadLine());

// double functionX = FunctionX(b1, k1, b2, k2);
// double functionY = FunctionY(b2, k2, functionX);

// Console.WriteLine($"({functionX};{functionY})");
