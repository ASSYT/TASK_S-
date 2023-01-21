// Задача 41: 
// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
double[] EnterArrayDouble(int size) // ввод массива
{
    double[] array = new double[size];
    // Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1} число = ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void PrintArrayDouble(double[] array) // выводит массив в консоль  
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + "; ");
        else Console.Write(array[i]);
    }
    }
int NumberPositive (double [] array) // счетчик по условию
{
int numberPositive = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0) numberPositive++; 
}
return numberPositive;
}

Console.Write("Введите количесво вводимых чисел М = ");
int raz = Convert.ToInt32(Console.ReadLine());

double[] arr = EnterArrayDouble(raz); // заполняем массив 
int number = NumberPositive (arr);    // счётчик положительных чисел

PrintArrayDouble(arr); // выводим в консоль заполненный массив
Console.WriteLine($" -> {number}"); // выводим в консоль кол-во пол. чисел из массива

