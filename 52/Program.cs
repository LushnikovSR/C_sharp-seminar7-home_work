// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
Console.WriteLine("Введите параметр - количество строкв массива: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите параметр - количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine("Введите параметр min для заполнения массива: ");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите параметр max для заполнения массива: ");
int max = int.Parse(Console.ReadLine());

int[,] baseArray = GetRandomArray(rows, columns, min, max);
Console.WriteLine();
Print2DArray(baseArray);
double[] arithMeans = GetArithmeticalAverageColumns(baseArray);
Console.Write($"Среднее арифметическое каждого столбца: ");
PrintArray(arithMeans);
Console.WriteLine();

double[] GetArithmeticalAverageColumns(int[,] inArray)
{
    double[] array = new double[inArray.GetLength(1)];
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < inArray.GetLength(0); j++)
        {
            sum += inArray[j, i];
        }
        array[i] = sum / inArray.GetLength(0);
    }
    return array;
}

int[,] GetRandomArray(int lengthArray, int weightArray, int minValue, int maxValue)
{
    int[,] array = new int[lengthArray, weightArray];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("{0:0.0}", array[i]);
        if (i < array.Length - 1) Console.Write("; ");
    }
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}