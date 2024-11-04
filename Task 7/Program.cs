using System;

class FibonacciCalculator
{
    public void CalculateAndPrintFibonacciSum(int limit)
    {
        int a = 0, b = 1, sum = 0, count = 0;

        while (a + b <= limit)
        {
            int next = a + b;
            sum += next;
            count++;
            a = b;
            b = next;
        }

        Console.WriteLine("Sum of Fibonacci numbers less than or equal to {0}: {1}", limit, sum);
        Console.WriteLine("Number of Fibonacci elements: {0}", count);
    }
}

class Program
{
    static void Main()
    {
        FibonacciCalculator fibonacciCalculator = new FibonacciCalculator();
        Console.WriteLine("Enter a limit:");
        int userInput = Convert.ToInt32(Console.ReadLine());
        fibonacciCalculator.CalculateAndPrintFibonacciSum(userInput);
    }
}
