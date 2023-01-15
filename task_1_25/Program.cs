// Задача 25: Напишите цикл, 
// принимает на вход два числа (A и B) 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int UserInput(string text) // метод пользовательского ввода
{
    Console.Write(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int userNumberA = UserInput("введите числа А = ");
int userNumberB = UserInput("введите числа B = ");
// проверка на натуральность числа В
while (userNumberB <= 0)
{
    userNumberB = UserInput("введите натуральное числа B = ");
}
int degreeNumber = userNumberA;
if (userNumberA == 0) degreeNumber = 0;
else
{
    int index = 2;
    while (index <= userNumberB) // возведение А в степень В 
    {
        degreeNumber *= userNumberA;
        index++;
    }
}
Console.Write($"{userNumberA}, {userNumberB} -> {degreeNumber}");