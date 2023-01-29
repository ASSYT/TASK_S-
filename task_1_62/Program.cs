// Задача 62. Напишите программу, 
// которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] SpiralMatrix(int raz, int elem) // созд.двумер. спирального массив 
{
int[,] nums = new int[raz, raz];
int i = 0;
int j = 0;
int maxElem = raz*raz+elem-1;

while (elem <= maxElem) //  ПОДСМОТРЕЛА В ИНТЕРНЕТЕ  разобралась     
{
    nums[i, j] = elem;
    if (i <= j + 1 && i + j < raz- 1) ++j;
    else if (i < j && i + j >= raz - 1) ++i;
    else if (i >= j && i + j > raz - 1) --j;
    else --i;
    ++elem;
}
return nums;
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

Console.Write("Введите первый элемент массива: ");
int ferstElem = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите размер массива: ");
int raz1 = Convert.ToInt32(Console.ReadLine());

int [,] spiralMatrix = SpiralMatrix(raz1, ferstElem); 

Console.WriteLine("");
PrintMatrix(spiralMatrix);
