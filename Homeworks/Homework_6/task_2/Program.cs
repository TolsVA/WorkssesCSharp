using System.ComponentModel;
using System;
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

PrintMesseg("\nДаны два уравнения: y = k1 * x + b1" +
                         "\n                    y = k2 * x + b2\n");

double k1 = PrintNumber("Введите k1 -> ");
double b1 = PrintNumber("Введите b1 -> ");
double k2 = PrintNumber("Введите k2 -> ");
double b2 = PrintNumber("Введите b2 -> ");

PrintResult(k1, b1, k2, b2);

PrintMesseg("Выведим формулу чему равен x = k1 * x + b1 = k2 * x + b2\n" + 
            "                               k1 * x - k2 * x = b2 - b1\n" +
            "                               (k1 - k2) * x = b2 - b1\n" +
            "                           ------------------------------\n" +
            "                           x = (b2 - b1) / (k1 - k2)");

double x = Divide(SubtractNumber(b2, b1), SubtractNumber(k1, k2));
double y = Summ(Multiply(k1, x), b1);

PrintMesseg($"\nКоординаты пересечения прямых (x, y) = ({x}, {y})\n");

double SubtractNumber(double num1, double num2) {
    return (num1 - num2);
}

double Divide(double num1, double num2) {
    if (num1 == 0 || num2 == 0) PrintMesseg("\nРешения нет ноль не делится и на ноль делить нельзя!!!");
    return (num1 / num2);
}

double Multiply(double num1, double num2) {
    return (num1 * num2);
}

double Summ(double num1, double num2) {
    return (num1 + num2);
}

void PrintResult(double k1, double b1, double k2, double b2) {
    System.Console.WriteLine($"\nk1 = {k1}\n" + 
                             $"b1 = {b1}\n" + 
                             $"y = ({k1}) * x + ({b1})\n\n" +
                             $"k2 = {k2}\n" +
                             $"b2 = {b2}\n" + 
                             $"y = ({k2}) * x + ({b2})\n");
}

double PrintNumber(string messeg){
    while (true){
        System.Console.Write($"{messeg}");
        string? word = Console.ReadLine();
        if (Int32.TryParse(word, out int number)) {
            return (double)number;
        } else if (word == null || word == "") {
            System.Console.WriteLine("Вы не чего не ввели!!!");
        } else {
            System.Console.WriteLine("Вводить можно только цифры!!!");
        }
    }
}

void PrintMesseg(string messeg){
    System.Console.WriteLine(messeg);
}

double[,] arr = new double[19, 19] {
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 2, 2, 2, 2, 2, 2, 2, 2, 5},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
};

PrintTwoDimensionalArray(arr);

void PrintTwoDimensionalArray(double[,] arr) {
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            
            double temp = (double)j;

            if (temp - 9 == Summ(Multiply(k1, (-1)*(i-9)), b1))
            {
                if (temp - 9 == Summ(Multiply(k2, (-1)*(i-9)), b2))
                {
                    Console.Write(" ο ");
                    
                }
                else
                {
                    Console.Write(" • ");
                }
                
            }
            else if (temp - 9 == Summ(Multiply(k2, (-1)*(i-9)), b2))
            {
                if (temp - 9 == Summ(Multiply(k1, (-1)*(i-9)), b1))
                {
                    Console.Write(" ο ");
                    
                }
                else
                {
                    Console.Write(" • ");
                }
            }
            else
                {
                if (arr[i, j] == 0)
                {
                    Console.Write("   ");
                } 
                else if(arr[i, j] == 1)
                {
                    Console.Write(" ¦ ");
                }
                else if(arr[i, j] == 2)
                {
                    Console.Write($"-{Math.Abs(j-9)}-");
                }
                else if(arr[i, j] == 3)
                {
                    Console.Write("-+-");
                }
                else if(arr[i, j] == 4)
                {
                    Console.Write(" ^ ");
                }
                else if(arr[i, j] == 5)
                {
                    Console.Write("-->");
                }
                }
        }
        Console.WriteLine();
        
    }
}