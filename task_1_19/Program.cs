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
int MaxDischarge(int num1)
{
    int maxDischarge = 10;
    while (num1 > 100)
    {
        maxDischarge = maxDischarge * 10;
        num1 = num1 / 10;
    }
    return maxDischarge;
}
int Сhangeling(int num2)
{
    int num2Discharge = MaxDischarge(num2);
    int changeling = 0;
    int discharge = num2Discharge;
    while (discharge > 1)
    {
        changeling = changeling + (num2 % 10) * discharge;
        num2 = num2 / 10;
        discharge = discharge / 10;
    }
    return changeling + num2;
}
int newNumber = Сhangeling(number);
string resalt = newNumber == number
        ? $"Введенное число: {number} является палиндромом"
        : $"Введенное число: {number} не является палиндромом";
Console.WriteLine(resalt);
// Console.WriteLine(newNumber);


//  для 5-знач числа
//     int index = 10;
//     int changeling = 0;
//     while (index <= 100000)
//     {
//         changeling = changeling + (num % 10) * 100000 / index;
//         num = num / 10;
//         index = index * 10;
//     }
//     return changeling;
// }







