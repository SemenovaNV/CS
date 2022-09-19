// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

int m = NumberEnteredByUser("Введите количество строк: ", "Ошибка ввода!");
int n = NumberEnteredByUser("Введите количество столбцов: ", "Ошибка ввода!");
int minNumberArray = NumberEnteredByUser("Введите минимальное число массива: ", 
                                            "Ошибка ввода!");
int maxNumberArray = NumberEnteredByUser("Введите максимальное число массива: ", 
                                            "Ошибка ввода!");                                           

int[,] array = GetArray(m, n, minNumberArray, maxNumberArray);
Print2DArray(array); 
Console.WriteLine();

SortDescending(array);
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
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void SortDescending(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int k = 0; k < array.GetLength(1); k++)     // перебираем К раз по количеству столбцов,
                                                         //чтоб все элементы сравнить друг с другом
        {
            for (int n = 0; n < array.GetLength(1) - 1; n++)
            {
                if (array[m, n] < array[m, n + 1])
                {
                    int temp = array[m, n];
                    array[m, n] = array[m, n + 1];
                    array[m, n + 1] = temp;
                }
            }
        }
    }
}