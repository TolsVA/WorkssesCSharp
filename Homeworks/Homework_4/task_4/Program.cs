﻿using Microsoft.VisualBasic;
using System;

string originalWord = enterAStringOfLetters();

string[] words = new string[factorial(originalWord.Length)];
int indexWords = 0;

allWords(originalWord, String.Empty);

Console.WriteLine($"[{String.Join(", ", words)}]");

string enterAStringOfLetters()
{
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

bool isEmpty(string word) => word.Length == 0;

int factorial(int n) { if (n == 1) return 1; else return n * factorial(n - 1); }


void allWords(string word, string permutation)
{
    if (isEmpty(word))
    {
        addWords(permutation);
        return;
    }

    for (int i = 0; i < word.Length; i++)
    {
        string newWord = word.Remove(i, 1);
        string newPermutation = permutation + word[i];
        allWords(newWord, newPermutation);
    }

}

void addWords(string word)
{
    if (indexWords <= words.Length)
    {
        words[indexWords] = word;
        indexWords++;
    }
}