// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();

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

void ProductOfMatrices(int[,] arrayOne, int[,] arrayTwo)
{
    int[,] product = new int[arrayOne.GetLength(0), arrayTwo.GetLength(1)];
    if (arrayOne.GetLength(1) == arrayTwo.GetLength(0))
    {
        for (int k = 0; k < product.GetLength(0); k++)
        {
            for (int i = 0; i < product.GetLength(1); i++)
            {
                for (int j = 0; j < arrayTwo.GetLength(0); j++)
                {
                    product[k, i] += arrayOne[k, j] * arrayTwo[j, i];
                }
            }
        }
        PrintArray(product);
    }
    else
    {
        System.Console.WriteLine("matrix multiplication is not possible");
    }
}

int[,] firstMatrix = CreateRandomArray(3, 4, 1, 5);
int[,] secondMatrix = CreateRandomArray(4, 3, 1, 5);
PrintArray(firstMatrix);
System.Console.WriteLine();
PrintArray(secondMatrix);
System.Console.WriteLine();
ProductOfMatrices(firstMatrix, secondMatrix);