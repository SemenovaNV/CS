// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

System.Console.Write("Введите положительное число: "); 
bool isNumber = int.TryParse(Console.ReadLine(), out int n); 

if(!isNumber || n !<= 0)
    {     
    Console.WriteLine("Ошибка при вводе данных");     
    return; 
    } 
// if (n !<= 0)
// {     
//     Console.WriteLine("Введено отрицательное число");     
//     return; 
//     } 

int index = 1;
while (index <= n)
{
    double cubeNumber = Math.Pow(index, 3);
    index++;
    Console.Write(cubeNumber + ", ");
} 

