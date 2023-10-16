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
    return fillArray(new int[size], size);
}

int[] fillArray(int[] arr, int size) {
    arr[--size] = rand.Next(1, 100);
    if (size == 0) {
        return arr;
    } else fillArray(arr, size);
    return arr;
}