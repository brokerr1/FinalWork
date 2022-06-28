Console.WriteLine("Создание исходного массива ...");
string[] arrString = CreateArrayString();
string[] CreateArrayString()
{ 
    Console.Write("Введите слова через пробел:");
    string[] array = Console.ReadLine().Split().ToArray();
    return array;
}