// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] arr = new int[PrintNumber("Размер массива -> ")];
int caunt = 0;
int[] resultArr = FillArray(0);
PrintMesseg("");
if (resultArr.Length > 0){
    PrintMesseg($"Вы ввели числа больше или раво нулю  -> {resultArr.Length} шт.");
} else {
    PrintMesseg($"Вы ввели все отрицательные числа");
}

PrintMesseg($"[{String.Join(", ", resultArr)}]");

int[] FillArray(int index) {
    if (index >= arr.Length) return new int[0];
    
    int temp = PrintNumber($"Введите {index + 1} число -> ");

    if(temp > 0) caunt++;
    
    resultArr = FillArray(++index);
       
    arr[index - 1] = temp;

    if (index >= arr.Length) {
        resultArr = new int[caunt]; 
    }

    if (resultArr.Length > 0 && temp > 0) {
        resultArr[--caunt] = temp;
    }

    if (index == 1) PrintMesseg($"\nВаши числа -> [{String.Join(", ", arr)}]");

    return resultArr;
}

int PrintNumber(string messeg){
    while (true){
        System.Console.Write($"{messeg}");
        string? word = Console.ReadLine();
        if (Int32.TryParse(word, out int number)) {
            return number;
        } else if (word == null || word == "") {
            System.Console.WriteLine("Вы не чего не ввели!!!");
        } else {
            System.Console.WriteLine("Вводить можно только цифры!!!");
        }
    }
}


void PrintMesseg(string messeg){
    System.Console.WriteLine(messeg);
}