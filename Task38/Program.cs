
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
// [3,5 7,1 22,9 2,3 78,5] -> 76

double[] create_random_array (int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
        {
            Console.Write($"Введите число с индексом {i}: ");
            array[i] = Convert.ToDouble(Console.ReadLine());
        }
    return array;
}
void write_array (double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
double difference_between_max_min (double[] array)
{
    double result = 0;
    double min = array[array.Length - 2];
    double max = array[array.Length - 1];
    for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
                max = array[i];
            if (array[i] < min)
                min = array[i];
            result = max - min;
        }
    return result;
}

Console.Write("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());

double[] my_array = create_random_array(length);
write_array(my_array);
Console.WriteLine(difference_between_max_min(my_array));