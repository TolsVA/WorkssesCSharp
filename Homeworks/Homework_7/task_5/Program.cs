using System;

Console.Clear();
int num = -1; 
int system = 4; //Троичная система

for (int i = 0; i <= 26; i++)
{
    num = AddOne(++num, system, 1, 0);
    System.Console.WriteLine($"i = {i}  num = {num}");
}

int AddOne(int num, int system, int digit, int remember) {
    if (num + remember == 0) return 0;
    
    int temp = 0;
    if (((num % 10) + remember) >= system)
    {
        temp = ((num % 10) + remember) - system;
        remember = 1;
    }
    else
    {
        temp = (num % 10) + remember;
        remember = 0;
    }
    int newNum = num / 10;

    return temp * digit + AddOne(newNum, system, digit * 10, remember);

}