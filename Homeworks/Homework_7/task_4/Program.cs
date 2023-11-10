using System.Diagnostics;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics.X86;
using System.Collections.Specialized;
using System.Text;
using System.Dynamic;
using System;

Console.Clear();

string[] system16 = new string[] { "A", "B", "C", "D", "E", "F" };

string originalWord = enterAStringOfLetters();

int caunt = 0;

var sw = new Stopwatch();

int originalWordLength = originalWord.Length;
int wordsLength = factorial(originalWordLength);
string[] words = new string[wordsLength];

int indexWords = 0;
int summIndex = 0;
string temp = IndexAndExpand(originalWord);

string revers = ReversTemp(temp);

// sw.Start();

AllOptions(temp, revers);

// sw.Stop();

// Console.WriteLine($"[{String.Join(", ", words)}]");

System.Console.WriteLine($"Время выполнения -> {sw.ElapsedMilliseconds}  caunt = {caunt} wordsLength = {wordsLength} лишних итераций -> {caunt - wordsLength}   summIndex = {summIndex}");

string IndexAndExpand(string temp)
{
    string newTemp = String.Empty;
    for (int i = 0; i < temp.Length; i++)
    {
        summIndex += i;
        newTemp = i + newTemp;
    }
    return newTemp;
}

string ReversTemp(string revers)
{
    string newTemp = String.Empty;
    for (int i = 0; i < temp.Length; i++)
    {
        newTemp = Convert.ToString(revers[i]) + newTemp;
    }
    return newTemp;
}

void AllOptions(string temp, string revers)
{
    int result = Convert.ToInt32(revers) - 1;
    int system = temp.Length;
    string newResult = "";

    sw.Start();

    // while (result < Convert.ToInt32(temp))
    // {
    //     result = AddOne(++result, system, 1, 0);
    //     System.Console.WriteLine($"result = {result}");
    //     if (summIndex == SummElementResult(result))
    //     {
    //         newResult = NewResult(Convert.ToString(result));

    //         // System.Console.WriteLine($"newResult = {newResult}");

    //         Summ(newResult);
    //     }
        caunt++;
    // }



    string[] strings = new string[factorial(originalWord.Length)];

    string[] stringsOst = new string[strings.Length];

    int lengthFac = factorial(originalWord.Length) / system;

    int index = 0;

    for (int i = 0; i < strings.Length; i++)
    {
        string wordRemove = originalWord;
        wordRemove = wordRemove.Remove(i, 1);
        for (int j = 0; j < lengthFac; j++)
        {
            strings[index] = originalWord[i].ToString();
            wordRemove = Shift(wordRemove);
            stringsOst[index] = wordRemove;
            System.Console.WriteLine($"[{String.Join(", ", strings)}]");   //Запусти код и все поймеш
            System.Console.WriteLine($"[{String.Join(", ", stringsOst)}]");
            // allWords2e(strings, stringsOst, index);
            index++;
        }

    }

    // allWords(originalWord, String.Empty);

    sw.Stop();
}

void allWords2e(string[] strings, string[] stringsOst, int index)
{

                    System.Console.WriteLine($"[{String.Join(", ", strings)}]");   //Запусти код и все поймеш
                System.Console.WriteLine($"[{String.Join(", ", stringsOst)}]");
    // int ff = 3;
    // while (ff > 0)
    // {
    //     for (int i = 0; i < strings.Length; i++)
    //     {
    //         string st = stringsOst[i].ToString();

    //             // st = Shift(st);
    //             strings[i] += st;
    //             System.Console.WriteLine($"[{String.Join(", ", strings)}]");   //Запусти код и все поймеш
    //             System.Console.WriteLine($"[{String.Join(", ", stringsOst)}]");

    
    //         // stringsOst[i] = st.Remove(i, 1);
    //     }
    //     ff--;
    // }

}

string Shift(string wordRemove)
{
    string newTemp = "";
    for (int i = 1; i < wordRemove.Length; i++)
    {
        newTemp += wordRemove[i].ToString();
    }
    newTemp += wordRemove[0].ToString();
    return newTemp;
}

bool isEmpty(string word) => word.Length == 0;

void allWords(string word, string permutation)
{
    if (isEmpty(word))
    {
        System.Console.WriteLine(permutation);
        return;
    }

    for (int i = 0; i < word.Length; i++) { allWords(word.Remove(i, 1), permutation + word[i]); }
}


int SummElementResult(int number) => number == 0 ? 0 : number % 10 + SummElementResult(number / 10);

string NewResult(string result)
{
    while (result.Length < originalWordLength)
    {
        result = 0 + result;
    }

    return result;
}

void Summ(string result)
{
    String newWord = "";

    int[] sum = new int[result.Length];

    int num = 0;

    for (int i = 0; i < result.Length; i++)
    {
        num = Convert.ToInt32(result[i].ToString());
        sum[num]++;
        newWord += originalWord[num];
    }

    if (AllElementsAreEqual(sum))
    {
        // System.Console.WriteLine($"result = {result}");
        addWords(newWord);
    }
}

bool AllElementsAreEqual(int[] ints)
{
    foreach (var item in ints)
    {
        if (item != 1) return false;
    }
    return true;
}

string enterAStringOfLetters()
{
    Console.WriteLine("Введите произвольные символы!");
    bool flag = true;
    while (flag)
    {
        string? word = Console.ReadLine();
        if (word == null || word == "") { Console.WriteLine("Вы не чего не ввели!!!"); }
        else
        {
            flag = false;
            return word;
        }
    }
    return String.Empty;
}

int factorial(int n) { if (n == 1) return 1; else return n * factorial(n - 1); }

void addWords(string word) { if (indexWords <= words.Length) { words[indexWords++] = word; } }

int AddOne(int num, int system, int digit, int remember)
{
    if (num + remember == 0) return 0;

    int temp = 0;
    int modulo = num % 10;
    if ((modulo + remember) >= system)
    {
        remember = 1;
    }
    else
    {
        temp = modulo + remember;
        remember = 0;
    }
    int newNum = num / 10;

    return temp * digit + AddOne(newNum, system, digit * 10, remember);
}