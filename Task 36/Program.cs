// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int size = NumberEnteredByUser("Введите длину массива: ", "Ошибка ввода!");
int minNumberArray = NumberEnteredByUser("Введите минимальное число диапозона массива: ", "Ошибка ввода!");
int maxNumberArray = NumberEnteredByUser("Введите максимальное число диапозона массива: ", "Ошибка ввода!");

int[] array = GetRandomArray(size, minNumberArray, maxNumberArray);
int sumNumberOddPosition = GetSumNumberOddPosition(array);

Console.WriteLine($" В массиве [{String.Join(", ", array)}] сумма элементов,стоящих на нечетных позициях = {sumNumberOddPosition}");

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

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int GetSumNumberOddPosition(int[] array)
{
    int sumNumber = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1) 
            sumNumber+= array[i];
    }
    return sumNumber;
}
