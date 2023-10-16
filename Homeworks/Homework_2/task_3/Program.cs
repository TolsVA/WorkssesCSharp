// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

print($"Введите числом день недели");

secondDigit(Convert.ToInt32(enterNumber()));

void secondDigit(int num) {
    
    if (num > 5) print($"{num} -> да"); else print($"{num} -> нет");

    print("Повторить программу? Нажмите <Y> чтобы согласиться или любую другую клавишу чтобы отказаться.");


    string? repeat = Console.ReadLine();

    if (repeat != null)
    {
        if (repeat.ToLower() == "y")
        {
            print($"Введите числом день недели");
            secondDigit(Convert.ToInt32(enterNumber()));
        }
    }
}

string enterNumber() {
    string? num = "";
    int caunt = -1;
    while(caunt != num!.Length) {
        num = Console.ReadLine();
        if (Int32.TryParse(num, out int number)){
            if(0 < number && number < 8) {
                caunt = num.Length;
            } else {
                caunt = -1;
                print($"{number} -> не входит в диапазон от 1 до 7");
            }
        } else {
            caunt = -1;
            print($"{num} -> не является числом. Вводить нужно только цыфры");
        }
    }
    return num!;
}

void print(string messeg) {
    Console.WriteLine($"{messeg}");
}