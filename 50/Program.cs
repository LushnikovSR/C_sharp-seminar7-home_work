// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();
Console.WriteLine("Введите параметр - количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите параметр - количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] baseArray = GetHandleArray(rows, columns);
GetPrintArray(baseArray);

Console.Write($"Для поиска задайте позицию элемента двумерного массива, начиная с 1, через пробел: ");
string[] stringElementCoordinate = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

if (CheckElementArray(baseArray, int.Parse(stringElementCoordinate[0]), int.Parse(stringElementCoordinate[1])))
{
    Console.WriteLine($"Позиция [{String.Join(", ", stringElementCoordinate)}] содержит " 
    +$"элемент {baseArray[int.Parse(stringElementCoordinate[0]) - 1, int.Parse(stringElementCoordinate[1]) - 1]}");
}
else
{
    Console.WriteLine($"Позиция [{String.Join(", ", stringElementCoordinate)}] отсутствует в массиве");
}

bool CheckElementArray(int[,] array, int rowIndex, int columnIndex)
{
    return ((array.GetLength(0) >= rowIndex) && (array.GetLength(1) >= columnIndex) && (rowIndex > 0) && (columnIndex > 0));
}

int[,] GetHandleArray(int lengthArray, int weightArray)
{
    int[,] array = new int[lengthArray, weightArray];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"Введите {weightArray} значений для {i + 1} строки массива, через пробел: ");
        string[] stringRowValues = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        for (int j = 0; j < array.GetLength(0); j++)
        {
            array[i, j] = int.Parse(stringRowValues[j]);
        }
    }
    return array;
}

void GetPrintArray(int[,] array)
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