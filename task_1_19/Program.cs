// Задача 19 Напишите программу, 
// принимает на вход пятизначное число
// проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

Console.Write("Введите любое неоднозначное целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
while (number < 10)
{
    Console.Write("Неверный ввод числа. Повторите ввод любого неоднозначное число: ");
    number = Convert.ToInt32(Console.ReadLine());
}
int Сhangeling(int num1)
{
    int changeling = 0;
    while (num1 > 0)
    {
        changeling = changeling*10+num1%10;
        num1 = num1 / 10;
    }
    return changeling;
}
int newNumber = Сhangeling(number);
string resalt = newNumber == number
        ? $"Введенное число: {number} является палиндромом"
        : $"Введенное число: {number} не является палиндромом";
Console.WriteLine(resalt);




