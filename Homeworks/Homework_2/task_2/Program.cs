// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

print($"Введите число");

secondDigit(Convert.ToInt32(enterNumber()));

void secondDigit(int num) {
    int result = Math.Abs(num / 100 % 10);
    if (result > 0)
    {
       print($"{num} -> {result}"); 
    } 
    else
    {
        print($"{num} -> третьей цифры нет");
    }

    print("Повторить программу? Нажмите <Y> чтобы согласиться или любую другую клавишу чтобы отказаться.");

    string? repeat = Console.ReadLine();

    if (repeat != null)
    {
        if (repeat.ToLower() == "y"){
            print($"Введите число");
            secondDigit(Convert.ToInt32(enterNumber()));
        }
    }

}
// Math.Abs(Convert.ToInt32(Console.ReadLine())).ToString().Length
string enterNumber() {
    int length = -2;
    int caunt = -1;
    string? num = "";
    while(caunt != length) {
        num = Console.ReadLine();
        if (num != null && num != "") {
            if (Int32.TryParse(num, out int number)) {
                length = Math.Abs(Convert.ToInt32(num)).ToString().Length;
                caunt = Math.Abs(number).ToString().Length;
            } else {
                caunt = -1;
                print($"{num} -> не является числом. Вводить нужно только цыфры");
            }
        } else {
            print("Вы ввели пустое значение попробуйте снова.");
        }
    }
    return num!;
}

void print(string messeg) {
    Console.WriteLine($"{messeg}");
}