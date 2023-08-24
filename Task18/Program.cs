﻿// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

string CoordinateRange(int num)
{
    if (num == 1) return "x > 0, y > 0";
    if (num == 2) return "x < 0, y > 0";
    if (num == 3) return "x < 0, y < 0";
    if (num == 4) return "x > 0, y < 0";
    return null;
}


Console.Write("Введите номер четверти: ");
int number = Convert.ToInt32(Console.ReadLine());
string result = CoordinateRange(number);

Console.Write(result != null ? result : "Некорректный ввод!");