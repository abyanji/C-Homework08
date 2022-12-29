// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Clear();

int DataEntry(string message)
{
    System.Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int[,] CreateRandomArray(int rows, int columns, int leftRange, int rightRange)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(leftRange, rightRange + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void BubbleSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - i - 1; j++)
        {
            if (array[j] < array[j + 1])
            {
                int buffer = array[j];
                array[j] = array[j + 1];
                array[j + 1] = buffer;
            }
        }
    }
}

void ArrangeRows(int[,] array)
{
    int[] row = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            row[j] = array[i, j];
        }
        BubbleSort(row);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = row[j];
        }
    }
    PrintArray(array);
}

int rows = DataEntry("Enter the value of rows: ");
int columns = DataEntry("Enter the value of columns: ");
int[,] matrix = CreateRandomArray(rows, columns, 0, 9);
PrintArray(matrix);
System.Console.WriteLine();
ArrangeRows(matrix);


