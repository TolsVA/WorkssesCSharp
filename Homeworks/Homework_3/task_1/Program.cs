using System;
// Внутри класса Answer напишите метод IsPalindrome,
// который принимает на вход пятизначное число number и проверяет, является ли оно палиндромом.
public class Answer
{
    static bool IsPalindrome(int number){
      // Введите свое решение ниже
      int lenghtNum = number.ToString().Length;
      if(lenghtNum == 5){
        string inverted = "";
        int divider = 1;
        for(int i = 0; i < lenghtNum; i++ ) {
            inverted +=$"{number/divider % 10}";
            divider *= 10;
        }
        int result = Convert.ToInt32(inverted);
        if (number == result)
        {
            System.Console.WriteLine($"Число {number} палиндром");
        } else {
            System.Console.WriteLine($"Число {number} не палиндром");
        }

        return true;
      } else {
        System.Console.WriteLine("Число не пятизначное");
        return false;
      }
      
    }
  
  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            // number = 64546;
            number = 14241;
            // number = 234322;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}