// Задача 58: Задайте две матрицы. 
// Напишите программу - произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
            else Console.Write($"{matrix[i, j],5}  ");
        }
        Console.WriteLine("|");
    }
}

int[,] MultMatrix(int[,] Martrix1, int[,] Martrix2)
{
    int resultMatrixRows = Martrix1.GetLength(0);
    int resultMatrixColon = Martrix1.GetLength(1);
    int[,] resultMatrix = new int[resultMatrixRows, resultMatrixColon];
    for (int i = 0; i < resultMatrixRows; i++)
    {
        for (int j = 0; j < resultMatrixColon; j++)
        {
            int sum = 0;
            for (int k = 0; k < resultMatrixColon; k++)
            {
                sum += Martrix1[i, k] * Martrix2[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
    return resultMatrix;
}

int[,] firstMartrix = CreateMatrixRndInt(3, 4, -5, 5);
Console.WriteLine($"Первая матрица:");
PrintMatrix(firstMartrix);
Console.WriteLine();

int[,] secondMartrix = CreateMatrixRndInt(4, 5, -5, 5);
Console.WriteLine($"Вторая матрица:");
PrintMatrix(secondMartrix);
Console.WriteLine();

int[,] multMatrix = MultMatrix(firstMartrix, secondMartrix);
Console.WriteLine($"Произведение матриц:");
PrintMatrix(multMatrix);
