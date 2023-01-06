// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

Console.Clear();

int[,] FillArraySpirally(int rows, int columns, int firstNumber)
{
    int[,] spiralArr = new int[rows, columns];
    spiralArr[0, 0] = firstNumber;
    int count = 1; 
    int i = 0;
    int j = 0;
    while (count < rows * columns)
    {
        while (j + 1 < spiralArr.GetLength(1) && spiralArr[i, j + 1] == 0)
        {
            firstNumber++;
            j++;
            spiralArr[i, j] = firstNumber;
            count++;
        }
        while (i + 1 < spiralArr.GetLength(0) && spiralArr[i + 1, j] == 0)
        {
            firstNumber++;
            i++;
            spiralArr[i, j] = firstNumber;
            count++;
        }
        while (j - 1 >= 0 && spiralArr[i, j - 1] == 0)
        {
            firstNumber++;
            j--;
            spiralArr[i, j] = firstNumber;
            count++;
        }
        while (i - 1 >= 0 && spiralArr[i - 1, j] == 0)
        {
            firstNumber++;
            i--;
            spiralArr[i, j] = firstNumber;
            count++;
        }
    }
    return spiralArr;
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

int rows = 4;
int columns = 4;
int firstNumber = 10;
int[,] spiralArray = FillArraySpirally(rows, columns, firstNumber);
PrintArray(spiralArray);