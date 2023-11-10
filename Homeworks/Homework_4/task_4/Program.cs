using System.Diagnostics;

Console.Clear();

string originalWord = enterAStringOfLetters();

var sw = new Stopwatch();
sw.Start();

string[] words = new string[factorial(originalWord.Length)];
int indexWords = 0;

allWords(originalWord, String.Empty);

sw.Stop();

Console.WriteLine($"[{String.Join(", ", words)}]");

Console.WriteLine($"Время выполнения -> {sw.ElapsedMilliseconds}");

string enterAStringOfLetters()
{
    while (true)
    {
        Console.WriteLine("Введите произвольные символы!");
        string? word = Console.ReadLine();
        if (word == null || word == "") Console.WriteLine("Вы не чего не ввели!!!");
        else
            return word;
    }
}

bool isEmpty(string word) => word.Length == 0;

int factorial(int n) => n == 1 ? 1 : n * factorial(n - 1);

void allWords(string word, string permutation)
{
    if (isEmpty(word))
    {
        addWords(permutation);
        return;
    }

    for (int i = 0; i < word.Length; i++) allWords(word.Remove(i, 1), permutation + word[i]);
}

void addWords(string word) { if (indexWords <= words.Length) { words[indexWords++] = word; } }