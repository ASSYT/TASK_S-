// Задача 8: Напишите программу, 
// на вход принимает число (N) 
// на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите натуральное число: ");
int N = Convert.ToInt32(Console.ReadLine());
// I вариант 
// for (int i = 2; i <= N; i = i + 2) Console.Write(" " + i);
// II вариант
int i = 2;
while (i <= N) 
{
Console.Write(" " + i); 
i = i + 2;
}