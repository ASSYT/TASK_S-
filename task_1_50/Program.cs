// Задача 50. Напишите программу, 
// на вход принимает позиции элемента в двумерном массиве,
// возвращает значение этого элемента 
// или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
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
void FindingElement(int[,] matrix, int row, int columns)
{
    if (row > matrix.GetLength(0) || columns > matrix.GetLength(1))
    {
        Console.WriteLine($"({row},{columns}) -> такого элемента нет");
    }
    else Console.WriteLine($"({row},{columns}) -> {matrix[row, columns]}");
}

int[,] array2D = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(array2D);

Console.Write("Напишите позиции элемента (номер строки, номер столбца), который хотите найти:  ");
string str = Console.ReadLine();
string[] strArray = str.Split(',');
int numRow = Convert.ToInt32(strArray[0]);
int numColumns = Convert.ToInt32(strArray[1]);

FindingElement(array2D, numRow, numColumns);
