// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.

int m = NumberEnteredByUser("Введите число 1: ", "Ошибка ввода!");
int n = NumberEnteredByUser("Введите число 2: ", "Ошибка ввода!");

if (m > n)
{
    Console.WriteLine("Ошибка ввода, второе число должно быть больше первого!");
    return;
}
else
    PrintNaturalsNambers(m, n);

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

string PrintNaturalsNambers(int start, int end)
{
    if (start == end + 1)
        return start.ToString();

    if (start == end)
        Console.WriteLine($"{start}");
    else
        Console.Write($"{start}, ");
    return PrintNaturalsNambers(start + 1, end);
}
