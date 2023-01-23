// Задача 52. 
// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
//      1 4 7 2
//      5 9 2 3
//      8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
double[] ArithMeanColumns(int[,] matrix)// расчет ср.ариф по столб. и запись в массив
{
    double[] arrayDouble = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        arrayDouble[j] = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            arrayDouble[j] = arrayDouble[j] + matrix[i, j];
        }
        arrayDouble[j] = Math.Round(arrayDouble[j] / matrix.GetLength(0), 1, MidpointRounding.ToZero);
    }
    return arrayDouble;
}
void PrintArrayDouble(double[] arrayDouble)// вывод в  консоль одномерного массива
{
    for (int j = 0; j < arrayDouble.Length; j++)
    {
        if (j < arrayDouble.Length - 1) Console.Write(arrayDouble[j] + ";  ");
        else Console.Write(arrayDouble[j]);
    }
    Console.WriteLine(".");
}

int[,] array2D = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(array2D);
double[] array1D = ArithMeanColumns(array2D);
Console.Write($"Среднее арифметическое каждого столбца: ");
PrintArrayDouble(array1D);