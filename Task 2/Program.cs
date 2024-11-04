using System;

class SumCalculator
{
    public void CalculateAndPrintSum(int start, int end)
    {
        int sum = 0;

        for (int i = start; i <= end; i++)
        {
            sum += i;
        }

        Console.WriteLine("Sum of numbers from {0} to {1}: {2}", start, end, sum);
    }
}

class Program
{
    static void Main()
    {
        SumCalculator sumCalculator = new SumCalculator();
        sumCalculator.CalculateAndPrintSum(1, 100);
    }
}
