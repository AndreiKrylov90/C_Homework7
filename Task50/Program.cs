// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] GenerateArray(int m, int n, int min, int max)
{
    int[,] array = new int[m, n];
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = random.Next(min, max + 1);
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

var array = GenerateArray(4, 3, 1, 9);
Console.WriteLine("Внимание, ваша матрица");
PrintArray(array);
Console.WriteLine();

Console.WriteLine("Найдем элемент массива по координатам");
Console.WriteLine("Введите номер строки");
if(!int.TryParse(Console.ReadLine(), out int m))
{
    Console.WriteLine("Введено нецелое число");
}
Console.WriteLine("Введите номер столбца");
if(!int.TryParse(Console.ReadLine(), out int n))
{
    Console.WriteLine("Введено нецелое число");
    return; 
}

if ((m-1) <0 || (n-1) < 0 || m > array.GetLength(0) || n > array.GetLength(1))
{
    Console.WriteLine("Такого элемента нет, ты погряз в матрице");
    return;
}

int FindElement(int[,] array, int m, int n)
{
    int Element = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i+1 == m && j+1 == n)
            {
                Element = array[i, j];
            }
        }
    return Element;
}

int result = FindElement(array, m, n);
Console.WriteLine("Искомый элемент равен " + result);