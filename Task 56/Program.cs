// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

int m = NumberEnteredByUser("Введите количество строк: ", "Ошибка ввода!");
int n = NumberEnteredByUser("Введите количество столбцов: ", "Ошибка ввода!");

bool isRectangle = RectangleArray(m,n);                                          

if (isRectangle == false)
{
    Console.WriteLine("Строки и столбцы равны, прямоугольный массив не получится!");
    return;
}

bool RectangleArray(int m, int n)
{
    return m != n;
}

int minNumberArray = NumberEnteredByUser("Введите минимальное число массива: ", 
                                            "Ошибка ввода!");
int maxNumberArray = NumberEnteredByUser("Введите максимальное число массива: ", 
                                            "Ошибка ввода!");     



int[,] array = GetArray(m, n, minNumberArray, maxNumberArray);
Print2DArray(array); 
Console.WriteLine();

int[] sumMeanRow = FindSumMeanRow(array);
Console.WriteLine($"Сумма элементов в каждой строке: [{String.Join(",  ", sumMeanRow)}]");

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


int[] FindSumMeanRow(int[,] array)
{ 
    int[] sum = new int[m];
    for (int i = 0; i < m; i++)
    {
        int sumRow = 0;
        for (int j = 0; j < n; j++)
        {
            sumRow += array[i, j];
        }
        sum[i] = sumRow;
    }
    return sum;
}

// int FindSumMeanRow(int[,] array, int i)
// {
//   int sumLine = array[i,0];
//   for (int j = 1; j < n; j++)
//   {
//     sumLine += array[i,j];
//   }
//   return sumLine;
//}

    int minSumRow = 0;
    int sumRow = FindSumMeanRow(array, 0);
    for (int i = 1; i < n; i++)
    {
        int tempSumRow = FindSumMeanRow(array, i);
        if (sumRow > tempSumRow)
        {
            sumRow = tempSumRow;
            minSumRow = i;
        }
    }   
    Console.WriteLine($"\n{minSumRow+1} - строкa с наименьшей суммой ({sumRow}) элементов ");

    