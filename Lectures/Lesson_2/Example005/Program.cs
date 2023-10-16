using System;
using System.Collections.ObjectModel;

using System.Linq.Expressions;
Console.WriteLine("Введите длинну массива");
int[] arr = new int[Convert.ToInt32(Console.ReadLine())]; // объявляем и определяем длинну массива

fillArray(arr); // заполняем массив

print(arr);

int max = maxElement(arr);

printMax(max);

void fillArray(int[] collections) { // метод заполнения массива
    for(int index = 0; index < arr.Length; index++){
        collections[index] = new Random().Next(1, 100);
    }
}

void print(int[] collections) {
    Console.WriteLine($"массив[{String.Join(", ", collections)}]");
}

void printMax(int max) {
    Console.WriteLine($"Максимальный элемент в массиве равен -> {max}");
}

int maxElement(int[] collections) {
    int max = 0;
    foreach(var arg in collections) {
        if(max < arg) max = arg;
    }
    return max;
}