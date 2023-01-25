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
}