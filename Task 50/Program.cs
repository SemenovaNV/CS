// Напишите программу, которая на вход принимает число и ищет в двумерном массиве, 
// и возвращает индексы этого элемента или же указание, что такого элемента нет.

int m = NumberEnteredByUser("Введите количество строк: ", "Ошибка ввода!");
int n = NumberEnteredByUser("Введите количество столбцов: ", "Ошибка ввода!");
int minNumberArray = NumberEnteredByUser("Введите минимальное число массива: ", 
                                            "Ошибка ввода!");
int maxNumberArray = NumberEnteredByUser("Введите максимальное число массива: ", 
                                            "Ошибка ввода!");
int number = NumberEnteredByUser("Введите искомое число: ", "Ошибка ввода!");                                            

int[,] array = GetArray(m, n, minNumberArray, maxNumberArray);
Print2DArray(array); 
SearchIndexNumbers(array, number);

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

void SearchIndexNumbers(int[,] array, int number)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (array[i, j] == number)
            { 
                Console.WriteLine($"Число {number} в двумерном массиве находится под индексом ({i};{j})"); 
            }
        }
        Console.WriteLine($"Искомое число {number} не найдено");
    }
}