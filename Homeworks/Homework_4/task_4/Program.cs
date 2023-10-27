using Microsoft.VisualBasic;
using System;

string word = enterAStringOfLetters();

string[] words = new string[factorial(word.Length)];
int countIndex = 0;
int tailLength = word.Length - 2;
int index = 0;
int indexWords = 0;
allWords(word, countIndex, tailLength);

Console.WriteLine($"[{String.Join(", ", words)}]");

string enterAStringOfLetters()
{
    bool flag = true;
    while (flag)
    {
        string? word = Console.ReadLine();
        if (Int32.TryParse(word, out int number))
        {
            System.Console.WriteLine("Вводить можно только буквы!!!");
        }
        else if (word == null || word == "")
        {
            System.Console.WriteLine("Вы не чего не ввели!!!");
        }
        else
        {
            flag = false;
            return word;
        }
    }
    return "";
}


string allWordsChar(string word, int position)
{
    char[] chars = word.ToCharArray();
    char temp = chars[position];
    for (int i = position; i < chars.Length - 1; i++)
    {
        chars[i] = chars[i + 1];
    }
    chars[chars.Length - 1] = temp;

    return $"{String.Join("", chars)}";
}

int factorial(int n)
{
    if (n == 1) return 1; else return n * factorial(n - 1);
}


void allWords(string word, int count, int tailLength)
{
    int length = word.Length - tailLength;

    // addWords(word);

    // for (int i = index; i < length; i++) {
    //     index++;

    //     word = allWordsChar(word, count);

    //     addWords(word);

    //     if (i == length) {
    //         index = 0;
    //         tailLength--;
    //         count++;
    //         if (tailLength < 0) return;


    //     } 

    //     allWords(word, count, tailLength);
    // } 
}
//Alt+Shift+f - форматирует код