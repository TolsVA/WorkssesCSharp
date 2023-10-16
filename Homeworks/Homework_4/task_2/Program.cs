// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int[] arr = {452, 82, 9012};
int  result;
for(int i = 0; i < arr.Length; i++) {
    result = 0;
    System.Console.WriteLine($"{arr[i]} -> {sumBits(arr[i])}");
}

int  sumBits(int num) {
    result += num % 10;
    if (num / 10 <= 0) return result;
    return sumBits(num /10);
}