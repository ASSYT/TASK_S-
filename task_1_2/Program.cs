// Задача 2: Напишите программу, 
// на вход принимает два числа 
// выдаёт, какое число большее, а какое меньшее
Console.Write("Введите первое число: ");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double number2 = Convert.ToDouble(Console.ReadLine());

if (number1 ==number2)
{
    Console.WriteLine("Введенные числа равны между собой");
}
else if (number1 < number2)
{
    Console.WriteLine($"Из чисел {number1} и {number2} максимальное число {number2}");
}
else 
Console.WriteLine($"Из чисел {number1} и {number2} максимальное число {number1}");

