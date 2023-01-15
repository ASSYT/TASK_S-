// Задача 29: 
// задаёт массив из 8 элементов
// выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
int[] CreateArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 100);
    }
    return array;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write($"{arr[i]},");
    }
    Console.Write($"{arr[arr.Length-1]} -> ");
}
void PrintArray1(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write($"{arr[i]},");
    }
    Console.WriteLine($"{arr[arr.Length-1]}]");
}
int[] arr = CreateArray(8);
PrintArray(arr);
// Console.WrateLine ($"[{PrintArray(arr)}]");
PrintArray1(arr);