// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/*
double[,] CreateRandom2dArray(int rows, int columns, double minValue, double maxValue)
{

    double[,] array = new double[rows, columns];
{
    Random random = new Random(); 

    for(int i = 0; i < rows; i++)
            for(int j = 0; j < columns; j++)
            {
                double randomValue = minValue + (random.NextDouble() * (maxValue - minValue));
                array[i, j] = randomValue;
            }
    return array;  
}          
}

void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j].ToString("0.00") + " ");

        Console.WriteLine();
    }
}

Console.Write("Input a quantity of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a quantity of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
double min = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a max possible value: ");
double max = Convert.ToDouble(Console.ReadLine());

double[,] myArray = CreateRandom2dArray(rows, columns, min, max);
Show2dArray(myArray);
*/

// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{

    int[,] array = new int[rows, columns];
{
    for(int i = 0; i < rows; i++)
            for(int j = 0; j < columns; j++)
                array[i, j] = new Random().Next(minValue, maxValue +1);

    return array;  
}          
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

void Arithmetic(int[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        double[] columnAverages = new double[columns];

        for (int j = 0; j < columns; j++)
        {
            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                sum += array[i, j];
            }
            columnAverages[j] = (double)sum / rows;
        }

        Console.WriteLine("\arithmetic averages of the elements in each column:");
        for (int j = 0; j < columns; j++)
        {
            Console.WriteLine($"column {j + 1}: {columnAverages[j].ToString("0.00")}");
        }
}

Console.Write("Input a quantity of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a quantity of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows, columns, min, max);
Show2dArray(myArray);
Arithmetic(myArray);
*/

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{

    int[,] array = new int[rows, columns];
{
    for(int i = 0; i < rows; i++)
            for(int j = 0; j < columns; j++)
                array[i, j] = new Random().Next(minValue, maxValue +1);

    return array;  
}          
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

static int FindElement(int[,] array, int row, int column)
{
    if (row >= 0 && row < array.GetLength(0) && column >= 0 && column < array.GetLength(1))
    
        return array[row, column];
        
    else
        
        return -1; // Возвращаем -1 как индикатор отсутствия элемента
        
}

Console.Write("Input a quantity of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a quantity of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows, columns, min, max);
Show2dArray(myArray);

Console.Write("Input row to search: ");
int searchRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Input column to search: ");
int searchColumn = Convert.ToInt32(Console.ReadLine());

int foundElement = FindElement(myArray, searchRow, searchColumn);
    if (foundElement != -1)
        Console.WriteLine($"Element at position ({searchRow}, {searchColumn}): {foundElement}");
    
    else
        Console.WriteLine("No element found at the specified position.");
    