using Microsoft.VisualBasic;
using System;

string word = enterAStringOfLetters();

string[] strings = new string[factorial(word.Length)];

allWords(word, 0);

Console.WriteLine($"[{String.Join(", ", strings)}]");


string enterAStringOfLetters() {
    bool flag = true;
    while (flag){
        string? word = Console.ReadLine();
        if (Int32.TryParse(word, out int number)) {
            System.Console.WriteLine("Вводить можно только цифры!!!");
        } else if (word == null || word == "") {
            System.Console.WriteLine("Вы не чего не ввели!!!");
        } else {
            flag = false;
            return word;
        }
    }
    return "";
}

void allWords(string word, int count) {
    if (count >= word.Length) return;

    word = allWordsChar(word, count);
    allWords(word, ++count); 
}

string allWordsChar(string word, int position) {
    strings[position] = word;
    
    char[] chars = word.ToCharArray();
    char temp = chars[0];
    for (int i = 0; i < chars.Length - 1 ; i++) {
        chars[i] = chars[i + 1];
    }
    chars[chars.Length - 1] = temp;

    word = new string(chars);

    return word;
}

int factorial(int n){
    if (n == 1) return 1; else return n * factorial(n - 1);
}