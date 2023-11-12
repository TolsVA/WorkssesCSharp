using Microsoft.VisualBasic;
using System.Diagnostics;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics.X86;
using System.Collections.Specialized;
using System.Text;
using System.Dynamic;
using System;

// Console.Clear();

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

    string newWord = "";

    sw.Start();

    while (result <= Convert.ToInt32(temp))
    {
        newResult = NewResult(result.ToString());

        if (Compare(newResult))
        {
            for (int i = 0; i < newResult.Length; i++)
            {
                newWord = newWord + originalWord[Convert.ToInt32(newResult[i].ToString())];
            }
            addWords(newWord);
            newWord = "";
        }

        result = Convert.ToInt32(SumSystem((newResult), NewResult((originalWordLength - 1).ToString()), originalWordLength));
        caunt++;
    }

    sw.Stop();
}

string SumSystem(string num1, string num2, int system)
{
    string result = "";
    int temp = 0;
    int remember = 0;
    for (int i = num1.Length - 1; i > -1; i--)
    {
        temp = Convert.ToInt32(num1[i].ToString()) + Convert.ToInt32(num2[i].ToString()) + remember;
        if (temp < system)
        {
            result = temp + result;
            remember = 0;
        }
        else
        {
            result = (temp - system) + result;
            remember = 1;
        }
    
    }

    return result;
}

bool Compare(string nums)
{
    int[] sum = new int[10];

    for (int i = 0; i < nums.Length; i++)
    {
        if (++sum[Convert.ToInt32(nums[i].ToString())] > 1) return false;
    }

    return true;
}

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

// int SummElementResult(int number) => number == 0 ? 0 : number % 10 + SummElementResult(number / 10);

// int MaxElement(int num, int max)
// {
//     if (num == 0) return max;

//     int temp = num % 10;
//     if (max < temp) max = temp;

//     return MaxElement(num / 10, max);
// }

// bool isEmpty(string word) => word.Length == 0;

// void allWords(string word, string permutation)
// {
//     if (isEmpty(word))
//     {
//         System.Console.WriteLine(permutation);
//         return;
//     }

//     for (int i = 0; i < word.Length; i++) { allWords(word.Remove(i, 1), permutation + word[i]); }
// }

// string converter(int number, int system)
// {
//     int temp = 0;
//     string result = "";
//     while (number > 0)
//     {
//         temp = number % system;
//         string tempString = temp.ToString();
//         if (temp >= 10)
//         {
//             for (int i = 0; i < system16.Length; i++)
//             {
//                 if (temp == i + 10)
//                 {
//                     tempString = system16[i];
//                 }

//             }
//         }

//         result = tempString + result;
//         number = number / system;
//     }
//     return result;
// }