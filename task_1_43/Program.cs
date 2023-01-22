// Задача 43: Напишите программу, 
// которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, 
// y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double UserInput(string text)// метод пользовательского ввода
{
    Console.Write($"Введите число {text} = ");
    double result = Convert.ToDouble(Console.ReadLine());
    return result;
}
void InterSectionPoint(double b1, double k1, double b2, double k2) // координаты точки пересечения
{
    if (k1 == k2 && b1 == b2) Console.Write("Прямые совпадают");
    else if (k1 == k2) Console.Write("Прямые паралельны и не имеют точек пересечения "); // (в двумерном пространстве)
    else
    {
        double coordinateX = ((b2 - b1) / (k1 - k2));
        double coordinateY = (k1 * coordinateX + b1);
        Console.Write($"({Math.Round(coordinateX, 2, MidpointRounding.ToZero)}; {Math.Round(coordinateY, 2, MidpointRounding.ToZero)})");
    }
}
double userNumberB1 = UserInput("b1");
double userNumberK1 = UserInput("k1");
double userNumberB2 = UserInput("b2");
double userNumberK2 = UserInput("k2");
Console.Write($"b1 = {userNumberB1}, k1 = {userNumberK1}, b2 = {userNumberB2}, k2 = {userNumberK2} -> ");
InterSectionPoint(userNumberB1, userNumberK1, userNumberB2, userNumberK2);
