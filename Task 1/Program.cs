using System;

class EvenNumbersPrinter
{
    public void PrintEvenNumbers(int start, int end)
    {
        Console.WriteLine("Even numbers from {0} to {1}:", start, end);

        for (int i = start; i <= end; i++)
        {
            if (IsEven(i))
            {
                Console.WriteLine(i);
            }
        }
    }

    private bool IsEven(int number)
    {
        return number % 2 == 0;
    }
}

class Program
{
    static void Main()
    {
        EvenNumbersPrinter evenNumbersPrinter = new EvenNumbersPrinter();
        evenNumbersPrinter.PrintEvenNumbers(1, 20);
    }
}