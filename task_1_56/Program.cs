// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max) // созд.двумер. массив int num рандом
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix) //вывод двум массива в консоль
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5},");
            else Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine("|");
    }
}

int NumberRowMinSumElements(int[,] matrix) // номер строки с минималь суммой элементов
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        minRow += matrix[0, j];
    }
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
        sumRow += matrix[i, j];
        }
        if (sumRow < minRow) // находит первую стр. с мин суммой, если поставить равно -> то последнюю строку с мин сум.
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    return minSumRow + 1;
}

int[,] array2D = CreateMatrixRndInt(4, 4, -1, 3);
PrintMatrix(array2D);
Console.WriteLine();
int result = NumberRowMinSumElements(array2D);
Console.Write($"Наименьшая сумма элементов в {result} строке");
// Console.Write($"выдаёт номер строки с наименьшей суммой элементов:{NumberRowMinSumElements(array2D)} строка");
// PrintArrayDouble(array1D);