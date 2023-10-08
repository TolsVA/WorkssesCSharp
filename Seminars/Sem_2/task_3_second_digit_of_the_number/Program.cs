int lenghtNum = 3;
Console.WriteLine("Введите трёхзначное число и более");

int caunt = 0;

string num = enterNumber(caunt, lenghtNum);

secondDigit(num.ToCharArray());

string enterNumber(int caunt, int lenghtNum) {
    string num = "";
    while(caunt < lenghtNum) {
        num = Console.ReadLine();
        int number;
        if(Int32.TryParse(num, out number)) {
            caunt = num.Length;
            if (caunt < lenghtNum){
                print($"Число {caunt} значное необходимо 3-х значное или более");
            }
        } else {
            caunt = 0;
            string result = "";
            print($"Вводить нужно только цыфры");
        }
    }
    return num;
}

void print(string messeg) {
    Console.WriteLine($"{messeg}");
}

void secondDigit(char[] chars) {
    int index = 0;
    
    print($"Выбери номер позиции числа от 1 до {chars.Length}");

    int number = Convert.ToInt32(Console.ReadLine());

    foreach(var (value, indexChars) in chars.Select((value, indexChars) => (value, indexChars))) { 
        int lenght = 1;
        int rank = 1;
        while( lenght < (chars.Length - indexChars) ) {
            rank *= 10;
            lenght++;
        }
        index++;

        if (indexChars == chars.Length - number){
            print($"{number}-я цифра = {value} разрядность {value} * {rank}");
        }
    }
}