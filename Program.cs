// Написать программу, которая из имеющегося массива строк, длина которых меньше либо равно 3 символа. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
Console.Clear();

string[] FilterShortStrings(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            count++;
        }
    }

    string[] result = new string[count];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            result[j] = arr[i];
            j++;
        }
    }

    return result;
}
void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"{i + 1}. {arr[i]}");
    }
}

Console.Write("Введите количество строк в массиве: ");
int n = int.Parse(Console.ReadLine());

string[] arr = new string[n];
for (int i = 0; i < n; i++)
{
    Console.Write($"Введите строку {i + 1}: ");
    arr[i] = Console.ReadLine();
}

Console.WriteLine("Исходный массив:");
PrintArray(arr);

Console.WriteLine("Результат:");
PrintArray(FilterShortStrings(arr));


