// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

int numberA = GetNumberFromUser("Введите целое число 1: ", "Ошибка ввода!");
int numberB = GetNumberFromUser("Введите целое число 2: ", "Ошибка ввода!");

int result = NumberToPowerNumber(numberA, numberB);

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int NumberToPowerNumber(int number, int power)
{
        int numberPower = 1;
    for (int i = 1; i <= Math.Abs(power); i++)
    {
        numberPower = numberPower * number;
    }

    if (power < 0)
        power = Math.Abs(power);

    return numberPower;
}
Console.WriteLine($"{numberA} в степени {numberB} = {result}");