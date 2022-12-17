Console.Write("Введите натуральное число: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i <= N; i = i + 2) Console.Write($" {i},");