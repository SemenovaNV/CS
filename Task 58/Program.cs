// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

int[,] arrayFirst = FillArray();

int[,] arrayTwo = FillArray();

int[,] FillArray()
{
    int m = NumberEnteredByUser("Введите количество строк: ", "Ошибка ввода!");
    int n = NumberEnteredByUser("Введите количество столбцов: ", "Ошибка ввода!");
    int minNumberArray = NumberEnteredByUser("Введите минимальное число массива: ", 
                                            "Ошибка ввода!");
    int maxNumberArray = NumberEnteredByUser("Введите максимальное число массива: ", 
                                            "Ошибка ввода!");   
    return GetArray(m, n, minNumberArray, maxNumberArray);
}

Print2DArray(arrayFirst); 
Console.WriteLine();
Print2DArray(arrayTwo); 
Console.WriteLine();

int[,] arrayResult = Matrix(arrayFirst, arrayTwo);
Print2DArray(arrayResult);

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
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
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

int[,] Matrix(int[,] arrayFirst, int[,] arrayTwo)
{
    int[,] result = new int[arrayFirst.GetLength(0), arrayTwo.GetLength(1)];
    for (int i = 0; i < arrayFirst.GetLength(0); i++)
    {
        for (int j = 0; j < arrayTwo.GetLength(1); j++)
        {
            for (int k = 0; k < arrayTwo.GetLength(0); k++)
            {
                var valueFirst = arrayFirst[i, k];
                var valueTwo = arrayTwo[k, j];
                result[i, j] += valueFirst * valueTwo;
            }
        }
    }
    return result;
}
