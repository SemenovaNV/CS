// Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] arr = GenerateArray(4, 4);
PrintArray(arr);

int[,] GenerateArray(int countRow, int countCol)
{
    int[,] array = new int[countRow, countCol];
    int count = 1;
    count = GetArraySpiral(array, 0, 0, count);
    count = GetArraySpiral(array, 1, 1, count);
    return array;
}
int GetArraySpiral(int[,] isArray, int startRow, int startColumn, int countNumber)
{
    int countRow = isArray.GetLength(0) - startRow;
    int countCol = isArray.GetLength(1) - startColumn;

    for (int j = startColumn; j < countCol; j++)
    {
        isArray[startRow, j] = countNumber;
        countNumber++;
    }

    for (int i = startRow + 1; i < countRow; i++)
    {
        isArray[i, countCol - 1] = countNumber;
        countNumber++;
    }
   
    for (int j = countCol - 2; j >= startRow; j--)
    {
        isArray[countRow - 1, j] = countNumber;
        countNumber++;
    }
    
    for (int i = countRow - 2; i > startColumn; i--)
    {
        isArray[i, startColumn] = countNumber;
        countNumber++;
    }

    return countNumber;
}

void PrintArray(int[,] isArray)
{
    for (int i = 0; i < isArray.GetLength(0); i++)
    {
        for (int j = 0; j < isArray.GetLength(1); j++)
        {
            Console.Write($"{isArray[i, j]}\t");
        }
        Console.WriteLine();
    }
}