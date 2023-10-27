using System;
using System.Linq;
using System.Runtime.InteropServices;

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

  public static int[] FindNumberByPosition(int[,] matrix, int rowPosition, int columnPosition)
  {
    if (matrix.GetLength(0) - 1 < rowPosition || matrix.GetLength(1) - 1 < columnPosition)
      return new int[] { 0, 0 };
    else
      return new int[] { matrix[rowPosition, columnPosition], 1 };
  }

  public static void PrintCheckIfError(int[] results, int X, int Y)
  {
    if (results[1] == 1)
      Console.WriteLine($"The number in [{X}, {Y}] is {results[0]}");
    else
      Console.WriteLine("There is no such index");
  }


  // Не удаляйте и не меняйте метод Main! 
  static public void Main(string[] args)
  {
    int n, m, k, x, y;

    if (args.Length >= 5)
    {
      n = int.Parse(args[0]);
      m = int.Parse(args[1]);
      k = int.Parse(args[2]);
      x = int.Parse(args[3]);
      y = int.Parse(args[4]);
    }
    else
    {
      // Здесь вы можете поменять значения для отправки кода на Выполнение
      n = 3;
      m = 4;
      k = 2;
      x = 2;
      y = 3;
    }

    // Не удаляйте строки ниже
    int[,] result = CreateIncreasingMatrix(n, m, k);
    PrintArray(result);
    PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);
  }
}