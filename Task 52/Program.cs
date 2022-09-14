// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int m = NumberEnteredByUser("Введите количество строк: ", "Ошибка ввода!");
int n = NumberEnteredByUser("Введите количество столбцов: ", "Ошибка ввода!");
int minNumberArray = NumberEnteredByUser("Введите минимальное число массива: ", 
                                            "Ошибка ввода!");
int maxNumberArray = NumberEnteredByUser("Введите максимальное число массива: ", 
                                            "Ошибка ввода!");
                                         
int[,] array = GetArray(m, n, minNumberArray, maxNumberArray);
Print2DArray(array); 
double[] averageMeanColumn = FindAverageMeanColumn(array);
Console.WriteLine($"Среднее арифметическое элементов в каждом столбце: [{String.Join(",  ", averageMeanColumn)}]");

int NumberEnteredByUser(string message,string messageError)
{
    while (true)
    {
        Console.Write(message);
        bool correctParse = int.TryParse(Console.ReadLine(), out int userNumber);
        if (correctParse)
            return userNumber;
        Console.WriteLine(messageError);
    }
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{array[i,j]}\t ");
        }
        Console.WriteLine();
    }
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] average = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            average[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return average;
}

double[] FindAverageMeanColumn(int[,] array)
{ 
    double[] average = new double[n];
    for (int j = 0; j < n; j++)
    {
        double res = 0;
        for (int i = 0; i < m; i++)
        {
            res += array[i, j];
        }
        average[j] = Math.Round((res / m), 1);
    }
    return average;
}
