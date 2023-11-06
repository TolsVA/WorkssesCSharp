using System.Runtime.Intrinsics.X86;
using System.Collections.Specialized;
using System.Text;
using System.Dynamic;
using System;
Console.Clear();

string[] system16 = new string[] { "A", "B", "C", "D", "E", "F" };

string originalWord = enterAStringOfLetters();

string[] words = new string[factorial(originalWord.Length)];

int indexWords = 0;

// string temp = String.Join("", Enumerable.Repeat(originalWord.Length - 1, originalWord.Length).ToArray());
string temp = IndexAndExpand(originalWord);

AllOptions(temp);

Console.WriteLine($"[{String.Join(", ", words)}]");


string IndexAndExpand(string temp)
{
    string newTemp = String.Empty;
    for (int i = 0; i < temp.Length; i++)
    {
        newTemp = i + newTemp;
    }
    return newTemp;
}

void AllOptions(string temp)
{

    int count = 0;
    string result = "0";
    // int result = Convert.ToInt32(temp);
    int system = temp.Length;
    while (Convert.ToInt32(result) < Convert.ToInt32(temp))
    {
        result = converter(++count, system);
        Console.WriteLine($"( {count} ) -> ( {result} )");
        Summ(result);
    }

    // while (result > 0)
    // {
    //     Console.WriteLine($"( {result} )");
    //     Summ($"{result}");
    //     result--;
    // }
}

void Summ(string result)
{
    String newWord = "";

    int temp = Convert.ToInt32(result);
    int[] sum = new int[result.Length];

    string num = "";


    for (int i = 0; i < result.Length; i++)
    {
        num = result[i].ToString();
        sum[Convert.ToInt32(num)] += 1;
        newWord += originalWord[Convert.ToInt32(num)];
    }

    if (AllElementsAreEqual(sum))
    {
        addWords(newWord);
        // Console.WriteLine($"[{String.Join(", ", words)}]");
    }
}

bool AllElementsAreEqual(int[] ints)
{
    bool result = true;
    foreach (var item in ints)
    {
        if (item != 1)
        {
            result = false;
            break;
        }
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

string converter(int number, int system)
{
    int temp = 0;
    string result = String.Empty;
    while (number > 0)
    {
        temp = number % system;
        string tempString = temp.ToString();
        if (temp >= 10)
        {
            for (int i = 0; i < system16.Length; i++)
            {
                if (temp == i + 10)
                {
                    tempString = system16[i];
                }

            }
        }

        result = tempString + result;
        number = number / system;
    }
    while (result.Length < system)
    {
        result = 0 + result;
    }
    return result;
}