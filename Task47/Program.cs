﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] GenerateArray(int m, int n, int min, int max)
{
    double[,] array = new double[m, n];
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = random.NextDouble()*random.Next(min, max + 1);
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j].ToString("0.#") + " ");
        Console.WriteLine();
    }
}

var array = GenerateArray(3, 4, -10, 10);
Console.WriteLine("Внимание, ваша матрица");
PrintArray(array);