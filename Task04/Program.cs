// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Пожалуйста введите 3 числа,");
Console.WriteLine("чтобы узнать максимальное из этих чисел");

Console.WriteLine("Введите первое целое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье целое число");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

int maxNum = 0;
if (firstNumber > maxNum) maxNum = firstNumber;
if (secondNumber > maxNum) maxNum = secondNumber;
if (thirdNumber > maxNum) maxNum = thirdNumber;
Console.Write("Максимальное значение имеет число " + maxNum);