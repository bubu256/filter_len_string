string[] InputStringArray(int len)
{
    string[] result = new string[len];
    for (int i = 0; i < len; i++)
    {
        result[i] = Console.ReadLine();
    }
    return result;
}

void PrintStringArray(string[] strArray)
{
    for (int i = 0; i < strArray.Length; i++)
    {
        Console.WriteLine(strArray[i]);
    }
}

Console.Write("Введите количество элементов массива: ");
int num = Int16.Parse(Console.ReadLine());

string[] inp_array = InputStringArray(num);

Console.WriteLine("Вывод: ");
PrintStringArray(inp_array);