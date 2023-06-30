using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj liczby oddzielone spacjami:");
        string input = Console.ReadLine();
        string[] numberStrings = input.Split(' ');

        int[] numbers = new int[numberStrings.Length];
        for (int i = 0; i < numberStrings.Length; i++)
        {
            numbers[i] = Convert.ToInt32(numberStrings[i]);
        }

        int median = CalculateMedian(numbers);
        Console.WriteLine("Mediana: " + median);
    }

    static int CalculateMedian(int[] numbers)
    {
        int length = numbers.Length;
        int[] sortedNumbers = new int[length];
        Array.Copy(numbers, sortedNumbers, length);
        Array.Sort(sortedNumbers);

        if (length % 2 == 0)
        {
            int middleIndex1 = length / 2 - 1;
            int middleIndex2 = length / 2;
            return (sortedNumbers[middleIndex1] + sortedNumbers[middleIndex2]) / 2;
        }
        else
        {
            int middleIndex = length / 2;
            return sortedNumbers[middleIndex];
        }
    }
}
