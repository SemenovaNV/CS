// Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.

int m = NumberEnteredByUser("Введите число 1: ", "Ошибка ввода!");
int n = NumberEnteredByUser("Введите число 2: ", "Ошибка ввода!");

int resultAckerman = FunctionAckerman(m, n);
Console.WriteLine($"Функция Аккермана для {m} и {n} = {resultAckerman}");

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

int FunctionAckerman(int m, int n)
{
    if (m == 0)
        return n + 1;

    if (m > 0 && n == 0)
        return FunctionAckerman(m - 1, 1);

    return FunctionAckerman(m - 1, FunctionAckerman(m, n - 1));
}