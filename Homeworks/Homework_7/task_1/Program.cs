using System;

public class Answer
{
  public static double[,] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom)
  {
    // Введите свое решение ниже
    var rand = new Random();
    double[,] arr = new double[m, n];
    for (int i = 0; i < m; i++)
    {
      for (int j = 0; j < n; j++)
      {
        arr[i, j] = (double)minLimitRandom + ((double)maxLimitRandom - (double)minLimitRandom) * rand.NextDouble();
      }
    }
    return arr;
  }

  public static void PrintArray(double[,] matrix)
  {
    // Введите свое решение ниже
    int index = 0;
    foreach (var arg in matrix)
    {
      System.Console.Write($"{string.Format("{0:f2}", arg)}\t");
      index++;
      if (index % matrix.GetLength(1) == 0)
      {
        index = 0;
        System.Console.WriteLine();
      }
    }
  }

  // Не удаляйте и не меняйте метод Main! 
  public static void Main(string[] args)
  {
    int m, n, minLimitRandom, maxLimitRandom;

    if (args.Length >= 4)
    {
      m = int.Parse(args[0]);
      n = int.Parse(args[1]);
      minLimitRandom = int.Parse(args[2]);
      maxLimitRandom = int.Parse(args[3]);

      double[,] array = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);

      // Выберем случайные индексы трех элементов матрицы array
      int row1 = new Random().Next(0, m);
      int col1 = new Random().Next(0, n);
      int row2 = new Random().Next(0, m);
      int col2 = new Random().Next(0, n);
      int row3 = new Random().Next(0, m);
      int col3 = new Random().Next(0, n);

      // Проверяем, являются ли выбранные элементы дробными числами
      bool isFractional1 = (array[row1, col1] % 1) != 0;
      bool isFractional2 = (array[row2, col2] % 1) != 0;
      bool isFractional3 = (array[row3, col3] % 1) != 0;

      // Если два из трех элементов не являются дробными числами, то бросаем исключение
      if ((isFractional1 && isFractional2) || (isFractional1 && isFractional3) || (isFractional2 && isFractional3))
      {
        Console.WriteLine("Все ок!");
      }
      else
      {
        throw new Exception("Выбранные элементы не содержат по крайней мере два дробных числа.");
      }
    }
    else
    {
      m = 3;
      n = 4;
      minLimitRandom = -10;
      maxLimitRandom = 10;

      double[,] result = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);
      PrintArray(result);
    }
  }
}
