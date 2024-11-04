using System;

class MultiplicationTable
{
    public void PrintTable(int number)
    {
        Console.WriteLine("Multiplication table for {0}:", number);

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("{0} x {1} = {2}", number, i, number * i);
        }
    }
}

class Program
{
    static void Main()
    {
        MultiplicationTable multiplicationTable = new MultiplicationTable();
        multiplicationTable.PrintTable(5); // Замініть 5 на бажане число користувачем
    }
}