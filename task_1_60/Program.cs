﻿// Задача 60. Сформируйте трёхмерный массив 
// з неповторяющихся двузначных чисел. 
// Напишите программу, 
// которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

// int[,,] CreateMatrixRndInt(int rows, int columns, int min, int max) // созд.трехмерный. массив  рандом двух зн неповтор
// {
//     int[,] matrix = new int[rows, columns];
//     Random rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix) //вывод двум массива в консоль
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("|");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5},");
//             else Console.Write($"{matrix[i, j],5} ");
//         }
//         Console.WriteLine("|");
//     }
// }

// int[,] array2D = CreateMatrixRndInt(4, 4, 10, 99);
// PrintMatrix(array2D);