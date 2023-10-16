string num = Console.ReadLine();
char[] chars = num.ToCharArray();
int index = 0;
foreach(var (value, indexChars) in chars.Select((value, indexChars) => (value, indexChars))) { 
    int lenght = 1;
    int rank = 1;
    while( lenght < (chars.Length - indexChars) ) {
        rank *= 10;
        lenght++;
    }
    index++;
    Console.WriteLine($"{value} * {rank}");
}