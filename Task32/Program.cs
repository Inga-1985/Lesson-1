
// / 32.Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот. [-4, -8, 8, 2]-> [4, 8, -8, -2]

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

bool ArrayElementCheck(int num, int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num) return true;
    }
    return false;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("] ");
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);
bool result = ArrayElementCheck(number, array);
Console.Write(result ? "Число найдено" : "Число не найдено");