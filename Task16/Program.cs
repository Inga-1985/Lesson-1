// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

bool checkSquareTwoNumbers(int firstNumber, int secondNumber)
{
    return firstNumber * firstNumber == secondNumber || secondNumber * secondNumber == firstNumber;
}

Console.WriteLine("Введите два числа");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

bool result = checkSquareTwoNumbers(num1, num2);
Console.WriteLine(result? "Да": "Нет");
