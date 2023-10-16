Console.WriteLine("Введите длинну массива");
int[] arr = new int[Convert.ToInt32(Console.ReadLine())]; // определяем длинну массива
for(int index = 0; index < arr.Length; index++) {
    Console.WriteLine($"Введите {index + 1} элемент массива");
    arr[index] = Convert.ToInt32(Console.ReadLine());
}
int max = 0;
foreach(var arg in arr) {
    if(max < arg) max = arg;
}
Console.WriteLine($"arr[{String.Join(", ", arr)}]");
Console.WriteLine($"Максимальный элемент в массиве arr равен -> {max}");