// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

void SortRowDescending(int[] row)
    {
        Array.Sort(row);
        Array.Reverse(row);
    }

void Sort2dArrayDescending(int[,] array)
    {
        int numRows = array.GetLength(0);

        for (int i = 0; i < numRows; i++)
        {
            int numCols = array.GetLength(1);
            int[] row = new int[numCols];

            for (int j = 0; j < numCols; j++)
            {
                row[j] = array[i, j];
            }

            SortRowDescending(row);

            for (int j = 0; j < numCols; j++)
            {
                array[i, j] = row[j];
            }
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
Console.WriteLine("Source array:");
Show2dArray(myArray);

Sort2dArrayDescending(myArray);

Console.WriteLine("Sorted array in descending order:");
Show2dArray(myArray);
*/

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int CalculateRowSum(int[,] array, int rowIndex)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[rowIndex, j];
        }
        return sum;
    }

int FindRowWithMinSum(int[,] array)
{
    int minSum = int.MaxValue;
    int minSumRowIndex = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int currentSum = CalculateRowSum(array, i);
        if (currentSum < minSum)
        {
            minSum = currentSum;
            minSumRowIndex = i;
        }
    }

    return minSumRowIndex;
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

Console.WriteLine("Source array:");
Show2dArray(myArray);

int minSumRowIndex = FindRowWithMinSum(myArray);
Console.WriteLine($"The row with the smallest sum of elements : {minSumRowIndex}");
*/

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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

int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
    {
        int rowsA = matrixA.GetLength(0);
        int colsA = matrixA.GetLength(1);
        int colsB = matrixB.GetLength(1);

        int[,] resultMatrix = new int[rowsA, colsB];

        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < colsB; j++)
            {
                int sum = 0;
                for (int k = 0; k < colsA; k++)
                {
                    sum += matrixA[i, k] * matrixB[k, j];
                }
                resultMatrix[i, j] = sum;
            }
        }

        return resultMatrix;
    }


Console.Write("Enter the number of rows of the first matrix: ");
int rowsA = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of columns of the first matrix: ");
int colsA = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the number of rows of the second matrix: ");
rowsB = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of columns of the second matrix: ");
int colsB = Convert.ToInt32(Console.ReadLine());

    if (colsA != rowsB)
        {
            Console.WriteLine("Matrix multiplication is not possible. The number of columns of the first matrix must be equal to the number of rows of the second matrix.");
            return;
        }

int[,] matrixA = CreateRandom2dArray(rowsA, colsA, 1, 10);
int[,] matrixB = CreateRandom2dArray(rowsB, colsB, 1, 10);

Console.WriteLine("The first matrix:");
Show2dArray(matrixA);

Console.WriteLine("The second matrix:");
Show2dArray(matrixB);

int[,] productMatrix = MultiplyMatrices(matrixA, matrixB);

Console.WriteLine("The result of multiplication:");
Show2dArray(productMatrix);
*/

//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int n = 4; 
int[,] spiralArray = new int[n, n];

int num = 1; // Начальное значение
int rowStart = 0;
int rowEnd = n - 1;
int colStart = 0;
int colEnd = n - 1;

while (num <= n * n)
{
    for (int i = colStart; i <= colEnd; i++)
            
        spiralArray[rowStart, i] = num++;
        rowStart++;

    for (int i = rowStart; i <= rowEnd; i++)
            
        spiralArray[i, colEnd] = num++;
        colEnd--;

    for (int i = colEnd; i >= colStart; i--)
    
        spiralArray[rowEnd, i] = num++;
        rowEnd--;

    for (int i = rowEnd; i >= rowStart; i--)
            
        spiralArray[i, colStart] = num++;
        colStart++;
}

        // Выводим получившийся массив
Console.WriteLine("Spirally filled array 4x4:");
    for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            
            Console.Write(spiralArray[i, j] + "\t");
            
            Console.WriteLine();
        }
    
    