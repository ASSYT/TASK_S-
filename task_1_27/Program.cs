// Задача 27: 
// принимает на вход число 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Write("Введите числа = ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = SumNum(number);
Console.Write($"Сумма цифр числа {number} -> {sum}");
int SumNum(int a1) // сумма цифр в числе а1
{
    int s = 0;
    for (; a1 >= 1; s = s + a1 % 10, a1 = a1 / 10) ;
    return s;
}