// Задача 6: Напишите программу, 
// на вход принимает число и 
// выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("Введите число: ");
double num = Convert.ToDouble(Console.ReadLine());
if (num < 0) Console.Write("Никакое отрицательное число не может быть четным или нечетным.");
else if (num == 0) Console.WriteLine("Число 0 является четным числом");
else if (num % 2 > 0) Console.WriteLine($"Число {num} не является четным числом");
else Console.WriteLine($"Число {num} является четным числом");
