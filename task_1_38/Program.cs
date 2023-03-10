// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
double[] CreateArrayRndDouble(int size, int min, int max) // создание рандомного массива вещ.элементов
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 1, MidpointRounding.ToZero);
    }
    return array;
}
void PrintArrayDouble(double[] array) // выводит массив в консоль  
{
    Console.Write($"[{string.Join("; ", array)}]");
}
double MaxNum(double[] array) // поиск максимального элемента в массиве
{
    double max = array[0];
    for (int i = 2; i < array.Length; i++)
    {
        max = max > array[i - 1] ? max : array[i - 1];
    }
    return max;
}
double MinNum(double[] array) // поиск минимального элемента в массиве
{
    double min = array[0];
    for (int i = 2; i < array.Length; i++)
    {
        min = min < array[i - 1] ? min : array[i - 1];
    }
    return min;
}
int size = 6, min = -5, max = 10; // наши данные
double[] arr = CreateArrayRndDouble(size, min, max);
PrintArrayDouble(arr);

double max1 = MaxNum(arr);
double min1 = MinNum(arr);

Console.WriteLine($" -> {Math.Round(max1 - min1, 1, MidpointRounding.ToZero)}");

// Console.Write($"{max1}");
// Console.WriteLine($"-{min1}");