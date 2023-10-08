using System;
class Program{
    static void Main(string[] args) {
        double a = new Random().Next(1, 10);
        double b = new Random().Next(1, 10);
        Calculator calculator = new Calculator();
        Console.Write(calculator.div(a, b));
        Console.WriteLine("");
        Console.Write(calculator.work(a, b));
        Console.WriteLine("");
        Console.Write(calculator.sum(a, b));
    }
}