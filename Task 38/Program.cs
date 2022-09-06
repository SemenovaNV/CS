// Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.

int size = NumberEnteredByUser("Введите длину массива: ", "Ошибка ввода!");
double minNumberArray = NumberEnteredByUser("Введите минимальное число диапозона массива: ", 
                                            "Ошибка ввода!");
double maxNumberArray = NumberEnteredByUser("Введите максимальное число диапозона массива: ", 
                                            "Ошибка ввода!");

double[] array = GetRandomArray(size, minNumberArray, maxNumberArray);
double DifferenceMaxMin = GetDiffBetweenMaxMin(array);

Console.WriteLine($" [{String.Join(", ", array)}] разница max и min элементов => {DifferenceMaxMin} ");


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

double[] GetRandomArray(int size, double minValue, double maxValue)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = Math.Round(new Random().NextDouble() * (maxValue - minValue) + minValue, 2);   //Math.random() * (max - min) + min;
    }
    return result;
}                 
double GetDiffBetweenMaxMin(double[] arr)
{
    int i = 0;
    double minNum = arr[i]; ;
    double maxNum = arr[i];
    double diffMinMax = 0;
    foreach (double element in arr)
    {
        if (element > maxNum) maxNum = element;
        if (element < minNum) minNum = element;
    }
    return diffMinMax = Math.Round(maxNum - minNum, 2);
}

