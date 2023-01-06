// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

Console.Clear();

int[] FullRandomArray(int length, int heigth, int width, int leftRange, int rigthRange) 
{

    int[] arrRandom = new int[length * heigth * width];
    if (length * heigth * width > rigthRange - leftRange + 1)
    {
        System.Console.WriteLine("insufficient array size");
        return arrRandom;
    }
    else
    {
        for (int i = 0; i < arrRandom.Length; i++)
        {
            arrRandom[i] = new Random().Next(leftRange, rigthRange + 1);
            if (i >= 1)
            {
                for (int j = 0; j < i; j++)
                {
                    while (arrRandom[i] == arrRandom[j])
                    {
                        arrRandom[i] = new Random().Next(leftRange, rigthRange + 1);
                        j = 0;
                    }
                }
            }
        }
        return arrRandom;
    }
}

int[,,] CreateRandomCube(int length, int heigth, int width, int leftRange, int rightRange)
{
    int[,,] cube = new int[length, heigth, width];
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < heigth; j++)
        {
            for (int k = 0; k < width; k++)
            {
                cube[i, j, k] = new Random().Next(leftRange, rightRange + 1);
            }
        }
    }
    return cube;
}

void PasteInArray(int[,,] arrayCube, int[] array)
{
    if (arrayCube.Length != array.Length)
    {
        System.Console.WriteLine("the sizes of the arrays do not match");
        return;
    }

    int count = 0;
    while (count < array.Length)
    {
        for (int i = 0; i < arrayCube.GetLength(0); i++)
        {
            for (int j = 0; j < arrayCube.GetLength(1); j++)
            {
                for (int k = 0; k < arrayCube.GetLength(2); k++)
                {
                    arrayCube[i, j, k] = array[count];
                    count++;
                }
            }
        }
    }
}

void PrintCube(int[,,] cube)
{
    for (int i = 0; i < cube.GetLength(0); i++)
    {
        for (int j = 0; j < cube.GetLength(1); j++)
        {
            for (int k = 0; k < cube.GetLength(2); k++)
            {
                System.Console.Write($"{cube[i, j, k]}({i},{j},{k}) ");
            }
            System.Console.WriteLine();
        }
    }
}

int length = 2;
int heigth = 2;
int width = 2;
int leftRange = 10;
int rightRange = 99;
int[,,] cube = CreateRandomCube(length, heigth, width, leftRange, rightRange);
int[] randomArray = FullRandomArray(length, heigth, width, leftRange, rightRange);
PasteInArray(cube, randomArray);
PrintCube(cube);