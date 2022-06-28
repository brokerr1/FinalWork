Console.WriteLine("Создание исходного массива ...");
string[] arrString = CreateArrayString();
Console.WriteLine("Дан исходный массив:");
PrintArrayString(arrString);
Console.WriteLine("Идет обработка массива ...");
string[] newArrString = CorrectionArrayString(arrString);
Console.WriteLine("Новый массив имеет вид:");
PrintArrayString(newArrString);
string[] CorrectionArrayString(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    string[] newArray = new string[count];
    int n = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[n] = array[i];
            n++;
        }
    }
    return newArray;
}
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