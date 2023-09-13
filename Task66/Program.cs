//Задача 66: Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30


int m = InputNumber("Введите M: ");
int n = InputNumber("Введите N: ");
int temp = m;

if (m > n)
{
    m = n;
    n = temp;
}

int sum = PrintSum(m, n);
Console.WriteLine($"Сумма элементов = {sum}");

int PrintSum(int m, int n)
{
    if (m == n)
    {
        return n;
    }
    int recursiveSum = PrintSum(m, n - 1);
    return n + recursiveSum;
}


int InputNumber(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine());
}




