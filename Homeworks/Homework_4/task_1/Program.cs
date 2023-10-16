using System.Text.RegularExpressions;
using System.Numerics;
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
// в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int[] arr1 = {3, 2};
int[] arr2 = {5, 4};

for(int i = 0; i < arr1.Length; i++) {
    System.Console.WriteLine($"{arr1[i]} ^ {arr2[i]} = {exponentiation(arr1[i], arr2[i])}");
}

int exponentiation(int num, int degree) {
    int result = num;
    while(degree > 1) {
        result *= num;
        degree--;
    }
    return result;
}