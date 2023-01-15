// Задача 25: Напишите цикл, 
// принимает на вход два числа (A и B) 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int UserInput(string text)// метод пользовательского ввода
{
    Console.Write(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int userNumberA = UserInput("введите числа А = ");
int userNumberB = UserInput("введите числа B = ");
int degreeNumber = userNumberA;
if (userNumberA == 0) degreeNumber = 0;
if (userNumberB == 0) degreeNumber = 1;
else
{
    if (userNumberB > 0) degreeNumber = DegreeNumber(userNumberA, userNumberB);
    else
    {
        degreeNumber = DegreeNumber(userNumberA, -userNumberB);
    }
}
Console.Write($"{userNumberA}, {userNumberB} -> {degreeNumber}");
int DegreeNumber(int a1, int b1) // возведение a1 в степень b1
{
    int degree = a1;
    for (int col = 2; col <= b1; degree *= a1, col++) ;
    return degree;
}
