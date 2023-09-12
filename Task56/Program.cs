// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

int[,] table = new int[4, 4];

// Метод для нахождения строки с наименьшей суммой элементов 
void FindRowWithMinSumElements(int[,] array)
{
    int minRow = int.MaxValue; // Инициализируем minRow максимальным значением
    int minSumRow = 0;
    int sumRow = 0;
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRow += array[i, j];
        }
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    
    Console.Write($"{minSumRow + 1} строка с наименьшей суммой элементов");
}

// Метод для вывода двумерного массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Метод для заполнения массива случайными числами от 1 до 9
void FillArrayRandomly(int[,] array)
{
    Random random = new Random();
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }
}

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

FillArrayRandom(table);
PrintArray(table);
Console.WriteLine();
FindRowWithMinSumElements(table);