// Задача 15: Напишите программу
// принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным
Console.Write("Введите цифру из от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1 || number > 7) Console.Write($"Введена некорректная цифра");
else
{
    Console.WriteLine(DayWeek(number) ? $"{number} --> выходной" : $"{number} --> не выходной");
}

bool DayWeek(int num)
{
    return num == 6 || num == 7;
}
