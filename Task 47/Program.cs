// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

int m = NumberEnteredByUser("Введите количество строк: ", "Ошибка ввода!");
int n = NumberEnteredByUser("Введите количество столбцов: ", "Ошибка ввода!");
double minNumberArray = NumberEnteredByUser("Введите минимальное число массива: ", 
                                            "Ошибка ввода!");
double maxNumberArray = NumberEnteredByUser("Введите максимальное число массива: ", 
                                            "Ошибка ввода!");

double[,] array = GetArray(m, n, minNumberArray, maxNumberArray);
Print2DArray(array);                                            

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

void Print2DArray(double[,] array)
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

double[,] GetArray(int m, int n, double minValue, double maxValue)
{
    double[,] result = new double[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = Math.Round(new Random().NextDouble() * (maxValue - minValue) + minValue, 1);
        }
    }
    return result;
}

