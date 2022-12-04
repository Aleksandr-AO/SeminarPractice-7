/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

double[,] CreatedRandom2dArray(int row, int column, int minValue, int maxValue)
{
    double[,] createdArray = new double[row, column];
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                createdArray[i, j] = Math.Round(new Random().Next(minValue, maxValue) + new Random().NextDouble(), 1);
            }
        }
    }
    return createdArray;
}

void ShowArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Input count of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Input count of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] arrayRand = CreatedRandom2dArray(rows, columns, min, max);
ShowArray(arrayRand);

Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет. Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет


int[,] CreatedRandom2dArray(int row, int column, int minValue, int maxValue)
{
    int[,] createdArray = new int[row, column];
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                createdArray[i, j] = new Random().Next(minValue, maxValue + 1);
            }
        }
    }
    return createdArray;
}

void Show(int[,] array, int row1, int column1)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    if (row1 < array.GetLength(0) & column1 < array.GetLength(1)) Console.WriteLine(array[row1, column1]);
    else Console.WriteLine($"{row1} - {column1} -> There is no such element");
}

Console.Write("Input count of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Input count of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());


Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.Write("Input position element (row): ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Input position element (column): ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] arrayRand = CreatedRandom2dArray(rows, columns, min, max);
Show(arrayRand, row, column);



Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] Create2dArray(int row, int column)
{
    int[,] created2dArray = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            created2dArray[i, j] = new Random().Next(0, 9);
    return created2dArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ShowAverageArithmetic(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
        }
        Console.Write(Math.Round(sum / array.GetLength(0), 1) + " | ");
    }
}

Console.Write("Input count of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Input count of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] newArray = Create2dArray(columns, rows);
Show2dArray(newArray);
ShowAverageArithmetic(newArray);

