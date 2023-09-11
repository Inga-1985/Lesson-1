// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int numberOfRows = ReadInt("Введите количество строк: ");
int numberOfColumns = ReadInt("Введите количество столбцов: ");
int[,] matrixA = new int[numberOfRows, numberOfColumns];
int[,] matrixB = new int[numberOfRows, numberOfColumns];
int[,] resultMatrix = new int[numberOfRows, numberOfColumns];

FillMatrixRandomly(matrixA);
PrintMatrix(matrixA);

Console.WriteLine();

FillMatrixRandomly(matrixB);
PrintMatrix(matrixB);

Console.WriteLine();

if (matrixA.GetLength(1) != matrixB.GetLength(0))
{
    Console.WriteLine("Нельзя перемножить матрицы.");
    return;
}

for (int i = 0; i < matrixA.GetLength(0); i++)
{
    for (int j = 0; j < matrixB.GetLength(1); j++)
    {
        resultMatrix[i, j] = 0;
        for (int k = 0; k < matrixA.GetLength(1); k++)
        {
            resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
        }
    }
}

PrintMatrix(resultMatrix);



int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


void FillMatrixRandomly(int[,] matrix)
{
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(1, 10);
        }
    }
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
