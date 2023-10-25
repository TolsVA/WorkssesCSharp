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

// void allWords(string word, int count) {
//     if (count >= word.Length) return;

//     int length = word.Length;
//     for (int i = 0; i < length; i++) {
//         for (int j = 0; j < word.Length; j++) {
//             word = allWordsChar(word, i);
//             words[count] = word;
//             System.Console.WriteLine($"i = {i} j = {j}  word = {word} count = {count}");
//             // count++;
//             allWords(word, ++count);
//         }
//     }
//     // allWords(word, ++count); 
// }

// string firstLevel(string word, int index) {
//     for (int i = index; i < word.Length - index; i++) {
//         word = allWordsChar(word, index);
//         words[count] = word;
//         count++;
//     }

//     return word;
//     // firstLevel(word, length - 1);

// }

string allWordsChar(string word, int position) {   
    char[] chars = word.ToCharArray();
    char temp = chars[position];
    for (int i = position; i < chars.Length - 1 ; i++) {
        chars[i] = chars[i + 1];
    }
    chars[chars.Length - 1] = temp;

    return $"{String.Join("", chars)}";
}

int factorial(int n){
    if (n == 1) return 1; else return n * factorial(n - 1);
}

// void allWords(string word, int count, int tailLength) {

//         // if (indexWords < words.Length) {
//         //     words[indexWords] = word;
//         //     System.Console.WriteLine($"words[{indexWords}] = {word}");
//         //     indexWords++;
//         // }

//     if (index != tailLength) {
//         index++;

//         // if (indexWords < words.Length) {
//         //     words[indexWords] = word;
//         //     System.Console.WriteLine($"words[{indexWords}] = {word}");
//         //     indexWords++;
//         // }

//         word = allWordsChar(word, count);
//     } else {
//         index = 0;
//         tailLength--;
//         if (tailLength < 0) return;
//         count++;
//     }

//     allWords(word, count, tailLength);

//                 if (indexWords < words.Length) {
//             words[indexWords] = word;
//             System.Console.WriteLine($"words[{indexWords}] = {word}");
//             indexWords++;
//         }

// }

// string firstLevel(string word, int index) {
//     for (int i = index; i < word.Length - index; i++) {
//         word = allWordsChar(word, index);
//         words[count] = word;
//         count++;
//     }

//     return word;
//     // firstLevel(word, length - 1);

// }


void allWords(string word, int count, int tailLength) {
    int length = word.Length - tailLength;

    addWords(word);

    for (int i = index; i < length; i++) {
        index++;

        word = allWordsChar(word, count);

        addWords(word);

        if (i == length) {
            index = 0;
            tailLength--;
            count++;
            if (tailLength < 0) return;
            

        } 

        allWords(word, count, tailLength);
    } 

    void addWords(string word) {
        if (indexWords < words.Length) {
            words[indexWords] = word;
            System.Console.WriteLine($"words[{indexWords}] = {word}");
            indexWords++;
        }
    }

    
    // if (indexWords < words.Length) {
    //     words[indexWords] = word;
    //     System.Console.WriteLine($"words[{indexWords}] = {word}");
    //     indexWords++;
    // }

    // allWords(word, count, tailLength);
}