// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int size = NumberEnteredByUser("Введите количество цифр: ", "Ошибка ввода!");
int[] arrayNum = GetArray(size);
int countNumGreaterZero = GetCountOfNumbersGreaterThanZero(arrayNum);

Console.WriteLine($"В перечне {String.Join(", ", arrayNum)} количество чисел больше 0 = {countNumGreaterZero}");

int NumberEnteredByUser(string message, string messageError)
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

int[] GetArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        int userNumber;
        while (true)
        {
            Console.WriteLine("Введите {0}-й элемент", i + 1);
            bool isCorrect = int.TryParse(Console.ReadLine(), out userNumber);
            if (isCorrect)
                break;
            Console.WriteLine("Ошибка, введите число");
            }
        arr[i] = userNumber;
    }
    return arr;
}

int GetCountOfNumbersGreaterThanZero(int[] arr)
{
    int count = 0;
    foreach (int element in arr)
    {
       if (element > 0)
       count++;
    }
    return count;
}