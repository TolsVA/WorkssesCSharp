using System.Text.RegularExpressions;
using System;

public class Answer
{
    // Внутри класса Answer напишите метод ShowCube, который принимает на вход число (N) и 
    // выводит таблицу кубов чисел от 1 до N (включительно) каждое на новой строке.
   static void ShowCube(int N)
    {
      // Введите свое решение ниже
      int caunt = 0;
      while (caunt != N)
      {
        System.Console.WriteLine(Math.Pow(++caunt, 3));
      }  
    }

  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int N;

        if (args.Length >= 1) {
            N = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            N = 6;
        }

        // Не удаляйте строки ниже
        ShowCube(N);
    }
}