// в консоли запрос len строк от пользователя
string[] InputStringArray(int len)
{
    string[] result = new string[len];
    for (int i = 0; i < len; i++)
    {
        result[i] = Console.ReadLine();
    }
    return result;
}

// вывод массива строк в консоль
void PrintStringArray(string[] strArray)
{
    for (int i = 0; i < strArray.Length; i++)
    {
        Console.WriteLine(strArray[i]);
    }
}

// возвращает отфильтрованный массив строк, 
// с строками длиной меньше или равно maxLen
string[] FilterLenArray(string[] strArray, int maxLen = 3)
{
    int count = 0;
    for(int i=0; i<strArray.Length; i++)
        if (strArray[i].Length <= maxLen) count++;
    
    string[] result = new string[count];
    count = 0;

    for (int i=0; i<strArray.Length; i++)
    {
        if (strArray[i].Length<=maxLen)
        {
            result[count] = strArray[i];
            count++;
        }
    }
    return result;
}


Console.Write("Введите количество элементов массива: ");
int num = Int16.Parse(Console.ReadLine());
Console.WriteLine("Вводите строки через Enter:");

string[] inp_array = InputStringArray(num);

Console.WriteLine("Вывод: ");
PrintStringArray(FilterLenArray(inp_array));