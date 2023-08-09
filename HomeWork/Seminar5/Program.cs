// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве

int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }

    return array;
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

int CountEvenNumbers(int[] array)
{
    int count = 0;

    foreach (int num in array)
    {
        if (num % 2 == 0) // Проверяем, четное ли число
            count++;
    }
    return count;
}

Console.Write("Input a length of array ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size);
WriteArray((myArray));

int CountNumber = CountEvenNumbers(myArray);
Console.Write($"number of even numbers: {CountNumber} ");



//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue +1);
    }

    return array;
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

int SumOfOddElements(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }

    return sum;
}

Console.Write("Input a length of array ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, minValue, maxValue);
WriteArray((myArray));

int sum = SumOfOddElements(myArray);
Console.WriteLine($"Sum: {sum}");
*/

//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
double[] CreateRandomArray(int size, double minValue, double maxValue)
{
    double[] array = new double[size];
    Random random = new Random();

    for(int i = 0; i < size; i++)
    {
        array[i] = random.NextDouble() * (maxValue - minValue) + minValue;
    }

    return array;
}

void WriteArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i].ToString("0.00") + " ");
    
    Console.WriteLine();
}

double FindMinValue(double[] array)
{
    double minValue = array[0];

    for (int i = 1; i < array.Length; i++)
        if (array[i] < minValue)
            
        minValue = array[i];
            
    return minValue;
}

double FindMaxValue(double[] array)
{
    double maxValue = array[0];

    for (int i = 1; i < array.Length; i++)
        if (array[i] > maxValue)
            maxValue = array[i];
                
    return maxValue;
}


Console.Write("Input a length of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
double min = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a max possible value: ");
double max = Convert.ToDouble(Console.ReadLine());

double[] myArray = CreateRandomArray(size, min, max);
WriteArray((myArray));

double minValue = FindMinValue(myArray);
    double maxValue = FindMaxValue(myArray);

    double difference = maxValue - minValue;

Console.WriteLine($"Min Value:{minValue:F2}");
Console.WriteLine($"Max Value:{maxValue:F2}");
Console.WriteLine($"Difference:{difference:F2}");
*/


