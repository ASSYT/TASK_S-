// Задача 54: Задайте двумерный массив. 
// Напишите программу - упорядочит по убыванию 
// элемент кажд. стр. двумерного массива.
// Например, задан массив:   В итоге получается вот такой массив:
// 1 4 7 2                   7 4 2 1
// 5 9 2 3                   9 5 3 2   
// 8 4 2 4                   8 4 4 2

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
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

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5},");
            else Console.Write($"{matrix[i, j],5}  ");
        }
        Console.WriteLine("|");
    }
}
void SortToDescending(int[,] matrix1)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1) - 1; k++)
            {
                if (matrix1[i, k] < matrix1[i, k + 1])
                {
                    int temp = matrix1[i, k + 1];
                    matrix1[i, k + 1] = matrix1[i, k];
                    matrix1[i, k] = temp;
                }
            }
        }
    }
}

int[,] array2D = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(array2D);
Console.WriteLine();
SortToDescending(array2D);
PrintMatrix(array2D);
