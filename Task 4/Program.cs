using System;

class FactorialCalculator
{
    public int CalculateFactorial(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }
        else
        {
            return n * CalculateFactorial(n - 1);
        }
    }
}

class Program
{
    static void Main()
    {
        FactorialCalculator factorialCalculator = new FactorialCalculator();
        Console.WriteLine("Enter a number:");
        int userInput = Convert.ToInt32(Console.ReadLine());
        int result = factorialCalculator.CalculateFactorial(userInput);
        Console.WriteLine("Factorial of {0}: {1}", userInput, result);
    }
}