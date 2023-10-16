int nun = 6;
System.Console.WriteLine($"{nun}! = {factorial(nun)}");

int factorial(int n){
    if (n == 1) return 1; else return n * factorial(n - 1);
}