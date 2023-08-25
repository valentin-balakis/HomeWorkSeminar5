// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
Console.Write("Введите количество чисел: ");
    int count = int.Parse(Console.ReadLine());

    int positiveCount = 0;

    for (int i = 0; i < count; i++)
        {
            Console.Write($"Введите число {i + 1}: ");
            int number = int.Parse(Console.ReadLine());

        if (number > 0)
            {
                positiveCount++;
            }
        }

Console.WriteLine($"Количество положительных чисел: {positiveCount}");
*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите уравнение первой прямой y = k1 * x + b1");
Console.Write("Введите k1: ");

    double k1 = double.Parse(Console.ReadLine());
    Console.Write("Введите b1: ");
    double b1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Введите уравнение второй прямой y = k2 * x + b2");
    Console.Write("Введите k2: ");
    double k2 = double.Parse(Console.ReadLine());
    Console.Write("Введите b2: ");
    double b2 = double.Parse(Console.ReadLine());

    double xIntersection = (b2 - b1) / (k1 - k2);
    double yIntersection = k1 * xIntersection + b1;

    Console.WriteLine($"Точка пересечения: ({xIntersection}, {yIntersection})");

        
    


        

            