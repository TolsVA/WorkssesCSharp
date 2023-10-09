// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

﻿var lenghtNum = 3;

print($"Введите {lenghtNum} значное число");

secondDigit(Convert.ToInt32(enterNumber(lenghtNum)));

void secondDigit(int num) => print($"{num} -> {Math.Abs(num / 10 % 10)}");

string enterNumber(int lenghtNum) {
    string? num = "";
    int caunt = 0;
    while(caunt != lenghtNum) {
        num = Console.ReadLine();
        if (Int32.TryParse(num, out int number)){
            caunt = Math.Abs(number).ToString().Length;
            if (caunt != lenghtNum){
                print($"Число {number} -> {caunt} значное необходимо {lenghtNum}-х значное");
            }
        } else {
            caunt = 0;
            print($"{num} -> не является числом. Вводить нужно только цыфры");
        }
    }
    return num!;
}

void print(string messeg) {
    Console.WriteLine($"{messeg}");
}