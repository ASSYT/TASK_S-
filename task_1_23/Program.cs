// Задача 23 Напишите программу
//принимает на вход число (N) 
// выдаёт таблицу кубов чисел от 1 до N.
// ПРИМЕР
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125
void Cube(int n1)
{
    int counter = 1;
    while (counter <= n1)
    {
        Console.WriteLine($"{counter} | {counter * counter * counter}");
        counter++;
    }
}
System.Console.Write($"Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number < 1)
{
    System.Console.Write("Введите положительное число:");
    number = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"{number} ->");
Cube(number);
