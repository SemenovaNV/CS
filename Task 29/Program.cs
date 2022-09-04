// Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.

int[] arrayNum = GetArray();
string arrayStr = ArrayToString(arrayNum);

string result = arrayStr;
Console.WriteLine($" Для чисел {result} -> массив [{result}]");

int[] GetArray()
{
    int[] arr = new int[8];
    for (int i = 0; i < arr.Length; i++)
    {
        int userNumber;
        while (true)
        {
            Console.WriteLine("Введите {0}-й элемент", i + 1);
            bool isCorrect = int.TryParse(Console.ReadLine(), out userNumber);
            if (isCorrect)
                break;
            Console.WriteLine("Ошибка");
        }
        arr[i] = userNumber;
    }
    return arr;
}

string ArrayToString(int[] arrayConvertToString)
{
    string strArray = string.Empty;
    foreach (int item in arrayConvertToString)
    {
        strArray += $"{item}, ";
    }
    strArray = strArray.Trim().Trim(',');
    return strArray;
}