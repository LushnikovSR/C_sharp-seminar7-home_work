// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
Console.WriteLine("Введите параметр - количество строкв массива: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите параметр - количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine("Введите параметр min для заполнения массива: ");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите параметр max для заполнения массива: ");
int max = int.Parse(Console.ReadLine());

double[,] baseArray = GetRandomArray(rows, columns, min, max);
GetPrintArray(baseArray);


double[,] GetRandomArray(int lengthArray, int weightArray, int minValue, int maxValue)
{
    double[,] array = new double[lengthArray, weightArray];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble() * (maxValue - minValue) + minValue;
        }
    }
    return array;
}

void GetPrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0:0.0 }", array[i, j]);
        }
        Console.WriteLine();
    }
}