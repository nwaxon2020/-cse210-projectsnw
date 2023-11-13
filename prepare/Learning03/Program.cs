using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");

        Function function1 = new Function();
        string funct1 = function1.GetFractionString();
        double funct2 = function1.GetDecimalValue();
        Console.WriteLine($"{funct1}\n{funct2}");

        Function function2 = new Function(5);
        string funct3 = function2.GetFractionString();
        double funct4 = function2.GetDecimalValue();
        Console.WriteLine($"{funct3}\n{funct4}");

        Function function3 = new Function(3,4);
        string funct5 = function3.GetFractionString();
        double funct6 = function3.GetDecimalValue();
        Console.WriteLine($"{funct5}\n{funct6}");

        Function function4 = new Function(1,3);
        string funct7 = function4.GetFractionString();
        double funct8 = function4.GetDecimalValue();
        Console.WriteLine($"{funct7}\n{funct8}");

    }
}