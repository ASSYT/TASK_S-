// Задача 10: Напишите программу, которая 
// принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 999 || number < 100) Console.WriteLine($"{number} - это не трёхзначное число");
else
{
    int secondDigit = SecondDigit(number);
    Console.Write($"Вторая цифра числа: {number} --> {secondDigit}");
}
int SecondDigit(int num)
{
    int num1 = num / 10;
    int result = num1 % 10;
    return result;
}