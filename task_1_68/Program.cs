// Задача 68: Напишите программу 
// вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int InsertDigit(string text) //Метод пользовательского ввода для целых чисел
{
    int result; bool parse;
    Console.Write(text);
    parse = Int32.TryParse(Console.ReadLine(), out result);
    if (!parse) result = InsertDigit(text);//Если пользователь ввел некорректное значение вызываем повтороно метод.
    return result;
}

int FunctionAckerman(int m, int n)
{
    while (m != 0)
    {
        if (n == 0) n = 1;
        else n = FunctionAckerman(m, n - 1);
        m = m - 1;
    }
    return n + 1;
}

int mUser = InsertDigit("Введите число m: ");
int nUser = InsertDigit("Введите число n: ");

int functionAckerman = FunctionAckerman(mUser, nUser);
Console.Write($"A ({mUser},{nUser}) -> {functionAckerman} ");