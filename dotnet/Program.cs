Console.WriteLine("Создание исходного массива ...");
string[] arrString = CreateArrayString();
Console.WriteLine("Дан исходный массив:");
PrintArrayString(arrString);
void PrintArrayString(string[] array)
{
    //Console.WriteLine("Сформированный массив:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("{0} ", array[i]);
    }
    Console.WriteLine();
}
string[] CreateArrayString()
{ 
    Console.Write("Введите слова через пробел:");
    string[] array = Console.ReadLine().Split().ToArray();
    return array;
}