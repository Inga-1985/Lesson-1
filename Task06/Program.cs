// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());
int remain = Number % 2;
if (remain == 0)
{
    Console.WriteLine("Число " + Number + " четное?");
    Console.WriteLine("ДА!");
}
else
{
    Console.WriteLine("Число " + Number + " четное?");
    Console.WriteLine("НЕТ!");
}
