// Задача 34: 
// Задайте массив 
// заполненный случайными положительными трёхзначными числами
// Напишите программу, которая покажет количество 
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int[] CreateArrayRndThree(int size, int min, int max) // создаем рандомно массив
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}
void PrintArray(int[] array) // выводим массив в консоль  
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.Write(array[i]);
    }
    Console.Write("]");
}
int NumberEven(int[] array) // счетчик при выполнении условия
{
    int num = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) num++;
    }
    return num;
}
Console.Write("Задайте длину массива: ");
int z = Convert.ToInt32(Console.ReadLine());
while (z<=0)
{
    Console.Write("Повторите ввод (не ноль и не отрицательное число): ");
    z = Convert.ToInt32(Console.ReadLine());
}
int[] arr = CreateArrayRndThree(z, 100, 999);
PrintArray(arr);
Console.WriteLine("");
int number = NumberEven(arr);
if (number==0) Console.WriteLine("В массиве четных элементов нет");
else Console.WriteLine($"В массиве четных элементов: {number}");