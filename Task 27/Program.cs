// Напишите программу, которая принимает на 
// вход число и выдаёт сумму цифр в числе.

int num = NumberEnteredByUser("Введите целое число: ", "Ошибка ввода!");

int sumDigits = SumDigitsNumber(num);

Console.WriteLine($"Сумма цифр в числе {num} = {sumDigits}");

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

int SumDigitsNumber(int number)
{
    int summa = 0;
    while (Math.Abs(number) > 0)
    {
        summa += number % 10;
        number /= 10; 
    }
    return summa;
}