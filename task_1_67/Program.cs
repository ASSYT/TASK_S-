// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Write("Enter natural number: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = SumDigits(number);
Console.WriteLine(sum);

int SumDigits(int number)
{
    if (number==0) return 0;
    return SumDigits(number/10)+number%10;
}