using Microsoft.VisualBasic;
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

Console.WriteLine($"[{String.Join(", ", words)}]");

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
    int result = Convert.ToInt32(revers);
   
    string newResult = "";

    sw.Start();

    while (result <= Convert.ToInt32(temp))
    {
        caunt++;
        result = Examination(result);

        while (Compare(result))
        {
            result += 9;
            result = Examination(result);
        }

        // Console.WriteLine($"result = {result}  MaxElement = {MaxElement(result, 0)}  Сумма = {SummElementResult(result)}" +
        // $"  {MaxElement(result, 0) != (originalWordLength - 1)} - {SummElementResult(result) != summIndex}");

        newResult = NewResult(Convert.ToString(result));

        addWords(CollectWord(newResult));

        result += 9;
    }

    sw.Stop();
}

string CollectWord(string num) {
    string newWord = String.Empty;
    for (int i = 0; i < num.Length; i++) newWord += originalWord[Convert.ToInt32(num[i].ToString())];

    return newWord;
}

int Examination(int result)
{
    while (MaxElement(result, 0) != (originalWordLength - 1))
    {
        result += 9;
        while (SummElementResult(result) != summIndex) result += 9;
        
    }
    return result;
}

bool Compare(int num)
{
    int[] sum = new int[10];

    while (num != 0)
    {
        if (++sum[num % 10] > 1) return true;
        num = num / 10;
    }

    return false;
}



int MaxElement(int num, int max)
{
    if (num == 0) return max;

    int temp = num % 10;
    if (max < temp) max = temp;

    return MaxElement(num / 10, max);
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