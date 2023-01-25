class Program
{
    public static string[] CreateArray()
    {
        Console.WriteLine("Введите элементы массива через пробел:");
        string input = Console.ReadLine()!;
        if (string.IsNullOrWhiteSpace(input)) return new string[0];
        string[] inputArray = input.Split(' ');
        return inputArray;
    }

    public static void PrintArray(string[] array)
    {
        Console.WriteLine();
        Console.WriteLine("Результирующий массив:");
        Console.WriteLine(string.Join(" ", array));
    }

    public static string[] FilteredArray(string[] initialArray)
    {
        int count = 0;
        for (int i = 0; i < initialArray.Length; i++)
        {
            if (initialArray[i].Length <= 3) count++;
        }

        int j = 0;
        string[] filteredArray = new string[count];
        for (int i = 0; i < initialArray.Length; i++)
        {
            if (initialArray[i].Length <= 3)
            {
                filteredArray[j] = initialArray[i];
                j++;
            }
        }
        return filteredArray;
    }
}