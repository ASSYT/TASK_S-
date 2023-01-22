/// Задача 41: 
// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
// double[] EnterArrayDouble(int size) // ввод массива
// {
//     double[] array = new double[size];
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"Введите {i + 1} число = ");
//         array[i] = Convert.ToDouble(Console.ReadLine());
//     }
//     return array;
// }
// void PrintArrayDouble(double[] array) // выводит массив в консоль  
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i < array.Length - 1) Console.Write(array[i] + "; ");
//         else Console.Write(array[i]);
//     }
// }
int[] ArrayInt(int size, string[] strArr) // перевод строкового массива в массив чисел
{
    int[] arrayInt = new int[size];
    for (int i = 0; i < strArr.Length; i++)
    {
        arrayInt[i] = Convert.ToInt32(strArr[i]);
    }
    return arrayInt;
}
// void PrintArrayDouble(double[] array) // выводит массив в консоль  
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i < array.Length - 1) Console.Write(array[i] + "; ");
//         else Console.Write(array[i]);
//     }
// }
int NumberPositive(int[] array) // счетчик по условию
{
    int numberPositive = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) numberPositive++;
    }
    return numberPositive;
}

Console.Write("Введите количество вводимых чисел М = ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите {num} чисел через запятую");
string str = Console.ReadLine();
string[] strArray = str.Split(',');
// double[] arr = EnterArrayDouble(raz); // заполняем массив 
int[] arrInt = ArrayInt(num, strArray); // перевод строкового массива в чисельный
int numberPositive = NumberPositive(arrInt);    // счётчик положительных чисел

// PrintArrayDouble(arr); // выводим в консоль заполненный массив
Console.WriteLine($" -> {numberPositive}"); // выводим в консоль кол-во пол. чисел из массива