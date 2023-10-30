using System.Text;
using System;

public class Answer
{
    public static void PrintArray(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j == matrix.GetLength(1) - 1)
                    Console.WriteLine($"{matrix[i, j]}");
                else
                    Console.Write($"{matrix[i, j]}\t");
            }
        }
    }

    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
        int[,] arr = new int[n, m];
        int temp = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (i == 0 && j == 0)
                    arr[i, j] = temp = 1;
                else
                    arr[i, j] = temp = temp + k;
            }
        }
        return arr;
    }

    static void PrintListAvr(double[] list)
    {
        System.Console.WriteLine("The averages in columns are:");
        string listDouble = String.Empty;
        foreach (var item in list)
        {
            listDouble += $"{string.Format("{0:f2}", item)}\t";
        }
        // Убираем последнюю табуляцию
        System.Console.WriteLine(listDouble[..^1]);
        // System.Console.WriteLine(listDouble.Remove(listDouble.Length - 1));
    }

    static double[] FindAverageInColumns(int[,] matrix)
    {
        double[] arraArithmeticColumn = new double[matrix.GetLength(1)];

        for (int column = 0; column < matrix.GetLength(1); column++)
        {
            double temp = 0.00;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                temp += (double)matrix[row, column];
                // System.Console.WriteLine($"temp = {temp}");
            }
            arraArithmeticColumn[column] = temp / ((double)matrix.GetLength(0));
        }
        return arraArithmeticColumn;
    }


    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int n, m, k;

        if (args.Length >= 3)
        {
            n = int.Parse(args[0]);
            m = int.Parse(args[1]);
            k = int.Parse(args[2]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            n = 3;
            m = 4;
            k = 2;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintListAvr(FindAverageInColumns(result));
    }
}