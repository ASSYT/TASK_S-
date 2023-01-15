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
    string result = "";
    for (int i = 0; i < arr.Length - 1; i++)
    {
        result += arr[i] + ", ";
    }
    result += arr[arr.Length - 1];
    Console.Write(result);
    Console.Write(" -> ");
    Console.Write($"[{result}]");
}
int[] arr = CreateArray(8);
PrintArray(arr);