// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

int m = NumberEnteredByUser("Введите число 1: ", "Ошибка ввода!");
int n = NumberEnteredByUser("Введите число 2: ", "Ошибка ввода!");

if (m > n)
{
    Console.WriteLine("Ошибка ввода, второе число должно быть больше первого!");
    return;
}
else
{
    int resultRecursive = SumNaturalNumbers(m, n);
    Console.WriteLine($"Сумма натуральных чисел в промежутке от {m} до {n} = {resultRecursive}");
}

int NumberEnteredByUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber > 0)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int SumNaturalNumbers(int start, int end)
{
    if (start == end)
        return start;
    return start+ SumNaturalNumbers(start + 1, end);
}