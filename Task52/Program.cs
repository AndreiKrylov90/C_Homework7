// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк в задаваемой матрице");
if (!int.TryParse(Console.ReadLine(), out int m) || m < 1)
{
    Console.WriteLine("Введено нецелое или отрицательное число или 0");
    return;
}
Console.WriteLine("Введите количество столбцов в задаваемой матрице");
if (!int.TryParse(Console.ReadLine(), out int n) || n < 1)
{
    Console.WriteLine("Введено нецелое или отрицательное число или 0");
    return;
}

void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine($"Введите число на позиции {i + 1}, {j + 1}");
            array[i, j] = Convert.ToDouble(Console.ReadLine());
        }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

double[,] array = new double[m, n];
FillArray(array);
Console.WriteLine("Внимание, ваша матрица:");
PrintArray(array);

double[] MeanOfColumn(double[,] array)
{
    double[] means = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
        }
        means[j] = sum / array.GetLength(0);
    }
    return means;
}

void PrintArray2(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i].ToString("##.#") + " ");
    }
}

double[] result = MeanOfColumn(array);
Console.WriteLine("Внимание, среднеарифметические значения столбцов равны:");
PrintArray2(result);


