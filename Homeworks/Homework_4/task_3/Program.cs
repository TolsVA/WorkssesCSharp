using System.Net.NetworkInformation;
using System.Data.Common;
using System;
using System.Reflection.Emit;
using System.Text;
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

var rand = new Random();
System.Console.WriteLine("Введите каличество эдементов в массиве.");
int[] arr =  createAnArray(enteTheNumber());
System.Console.WriteLine($"arr[{arr.Length}] -> [{string.Join(", ", arr)}]");

int enteTheNumber() {
    bool flag = true;
    while (flag){
        if (Int32.TryParse(Console.ReadLine(), out int number)) {
            flag = false;
            return number;
        } else System.Console.WriteLine("Вводить можно только цифры!!!");
    }
    return 0;
}
 
int[] createAnArray(int size) {
    return fillArray(new int[size], size, 0);
}

int[] fillArray(int[] arr, int size, int level) {
    // Назначение и вывод аргумента, и вывод отступов до наступления рекурсии будет в порядке вызова
/*     String prefix = "";
    IEnumerable<string> strings = Enumerable.Repeat("\t", level);

    foreach (String str in strings) {
        prefix += str;
    }

    String prefix2 = "";
    IEnumerable<string> strings2 = Enumerable.Repeat("\t", size + 1);

    foreach (String str in strings2) {
        prefix2 += str;
    }

    arr[--size] = rand.Next(1, 100);
    System.Console.WriteLine($"{prefix}введен элемент под индексом {size}{prefix2} -> [{string.Join(", ", arr)}]"); */

    if (--size < 0) { // Не забудь заменить --size -> size
        return arr;
    } else fillArray(arr, size, ++level);

    // Назначение и вывод аргумента, и вывод отступов после рекурсии будет в обратном порядке вызова
    String prefix = "";
    IEnumerable<string> strings = Enumerable.Repeat("\t", level);

    foreach (String str in strings) {
        prefix += str;
    }

    String prefix2 = "";
    IEnumerable<string> strings2 = Enumerable.Repeat("\t", size + 1);

    foreach (String str in strings2) {
        prefix2 += str;
    }

    arr[size] = rand.Next(1, 100);
    System.Console.WriteLine($"{prefix}введен элемент под индексом {size}{prefix2} -> [{string.Join(", ", arr)}]");
    return arr;
}