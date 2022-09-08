// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

int numberb1 = NumberEnteredByUser("Введите значение b1 =: ", "Ошибка ввода!");
int numberk1 = NumberEnteredByUser("Введите значение k1 =: ", "Ошибка ввода!");
int numberb2 = NumberEnteredByUser("Введите значение b2 =: ", "Ошибка ввода!");
int numberK2 = NumberEnteredByUser("Введите значение k2 =: ", "Ошибка ввода!");
LineIntersection(numberb1, numberk1, numberb2, numberK2);

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

void LineIntersection(double b1, double k1, double b2, double k2)
{
    double coordinatesX = (b2 - b1) / (k1 - k2);
    double coordinatesY = k1 * coordinatesX + b1;
    if (k1 == k2 && b1 != b2)
        Console.WriteLine("Заданные прямые параллельны!");
    else if (k1 == k2 && b1 == b2)
        Console.WriteLine("Заданные прямые идентичны");
    else
        Console.WriteLine($"Точка пересечения для двух прямых с координатами b1 = {b1}, k1 = {k1}, " + 
        $"b2 = {b2}, k2 = {k2} => ({coordinatesX}; {coordinatesY})");
}
