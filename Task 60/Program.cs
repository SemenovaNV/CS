// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

int x = NumberEnteredByUser("Введите количество строк: ", "Ошибка ввода!");
int y = NumberEnteredByUser("Введите количество столбцов: ", "Ошибка ввода!");
int z = NumberEnteredByUser("Введите ширину: ", "Ошибка ввода!");                                         

int[,,] array = GetArray(x, y, z);
Print3DArray(array); 

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

void Print3DArray(int[,,] array)
{
    for (int i = 0; i < z; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < x; k++)
            {
            Console.Write($"{array[i, j, k]} ({i},{j},{k}) "); 
            }
            Console.WriteLine();
        }
    }
}

int[,,] GetArray(int x, int y, int z)
{
    int[] arrRandomNum = GenerateArray(x, y, z);

    int[,,] result = new int[x, y, z];
    int nextIndexRandomNumber = 0;
    for (int k = 0; k < z; k++)
    {
        for (int j = 0; j < y; j++)
        {
             for (int i = 0; i < x; i++)
            {
                result[i, j, k] = arrRandomNum[nextIndexRandomNumber];
                nextIndexRandomNumber++;
            }
        }
    }
    return result;
}

int[] GenerateArray(int x, int y, int z)
{
    int length3DArray = x * y * z;
    int[] arrRandomNum = new int[length3DArray];
    for (int i = 0; i < arrRandomNum.Length; i++)
    {
        bool contains = true;
        int next = 0;
        while (contains)
        {
            next = new Random().Next(10, 99 + 1);
            contains = arrRandomNum.Contains(next);
        }
        arrRandomNum[i] = next;
    }

    return arrRandomNum;
}


