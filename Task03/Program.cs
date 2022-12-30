// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

void ProductOfMatrices(int[,] arrayOne, int[,] arrayTwo)
{
    int[,] product = new int[arrayOne.GetLength(0), arrayTwo.GetLength(1)];
    if (arrayOne.GetLength(1) == arrayTwo.GetLength(0))
    {
        for (int k = 0; k < product.GetLength(0); k++)
        {
            for (int i = 0; i < arrayOne.GetLength(1); i++)
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

int rows = DataEntry("Enter the value of rows: ");
int columns = DataEntry("Enter the value of columns: ");
int[,] firstMatrix = CreateRandomArray(rows, columns, 1, 5);
int[,] secondMatrix = CreateRandomArray(rows, columns, 1, 5);
PrintArray(firstMatrix);
System.Console.WriteLine();
PrintArray(secondMatrix);
System.Console.WriteLine();
ProductOfMatrices(firstMatrix, secondMatrix);
//Работает только с одинаковыми по размеру матрицами, как сделать чтобы работало с прямоугольными я не додумал :(