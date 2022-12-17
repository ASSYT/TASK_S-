// Задача 4: Напишите программу, 
// принимает на вход три числа 
// выдаёт максимальное из этих чисел
Console.Write("Введите первое число: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите третье число: ");
double num3 = Convert.ToDouble(Console.ReadLine());
double max = num1;
if (num1 == num2 && num1 == num3) Console.WriteLine("Введенные числа равны между собой");
else if (num1 == num2)
{
    if (max < num3)
    {
        max = num3; Console.WriteLine($"Из чисел {num1} {num2} {num3} максимальное число {max}");
    }
    else Console.WriteLine($"Из чисел {num1} {num2} {num3} максимальное число {max}");
}
else if (num1 == num3)
{
    if (max < num2)
    {
        max = num2; Console.WriteLine($"Из чисел {num1} {num2} {num3} максимальное число {max}");
    }
    else Console.WriteLine($"Из чисел {num1} {num2} {num3} максимальное число {max}");
}
else if (max > num2 && max > num3) Console.WriteLine($"Из чисел {num1} {num2} {num3} максимальное число {max}");
else if (num2 > max && num2 > num3)
{
    max = num2; Console.WriteLine($"Из чисел {num1} {num2} {num3} максимальное число {max}");
}
else
{
    max = num3; Console.WriteLine($"Из чисел {num1} {num2} {num3} максимальное число {max}");
}

