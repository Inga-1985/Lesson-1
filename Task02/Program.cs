// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// 1. на выход принимает два числа и 
// 2. выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Пожалуйста введите 2 числа,");
Console.WriteLine("чтобы узнать какое большее, а какое меньшее.");
Console.WriteLine("Введите первое целое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    Console.WriteLine("Число " + firstNumber + " большее");
    Console.Write("Число " + secondNumber + " меньшее");
}
else if (firstNumber == secondNumber)
{
    Console.WriteLine("Число " + firstNumber + " равно числу " +  secondNumber);
}
else
{
    Console.WriteLine("Число " + secondNumber + " большее");
    Console.Write("Число " + firstNumber + " меньшее");
}


