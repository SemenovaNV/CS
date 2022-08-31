// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

System.Console.WriteLine("Введите пятизначное число:");
string strNumber = Console.ReadLine();
bool isNumber = int.TryParse(strNumber, out int n); 

if(!isNumber)
{     
    Console.WriteLine("Ошибка! Это не число");     
    return; 
} 

int length = 5;
if (strNumber.Length != length)
{
    Console.WriteLine("Ошибка! это не 5-ти значное число");
    return;
}

char[] arr = strNumber.ToCharArray();
Array.Reverse(arr);
string str = new string(arr);
if (strNumber == str)
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число НЕ является палиндромом");
}
