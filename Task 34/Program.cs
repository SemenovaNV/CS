// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int size = NumberEnteredByUser("Введите длину массива: ", "Ошибка ввода!");
int[] array = GetRandomArray(size, 100, 999);
int countEvenNumbers = GetEvenNumbers(array);

Console.WriteLine($" В массиве [{String.Join(", ", array)}] количество четных чисел = {countEvenNumbers}");

int NumberEnteredByUser(string message,string messageError)
{
    while (true)
    {
        Console.Write(message);
        bool correctParse = int.TryParse(Console.ReadLine(), out int userNumber);
        if (correctParse && userNumber > 0)
            return userNumber;
        Console.WriteLine(messageError);
    }
}

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

 int GetEvenNumbers(int[] arr)
{
    int evenNumbers = 0;
    foreach (int el in arr)
    {
        if (el % 2 == 0) 
            evenNumbers++;
    }
    return evenNumbers;
}