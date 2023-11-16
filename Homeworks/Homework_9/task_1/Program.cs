// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
int n = 8;
System.Console.WriteLine($"\nВсе натуральные числа в промежутке от {n} до 1.");
System.Console.Write($"N = {n} -> \"");
DumberDigits(n);

void DumberDigits(int num)
{
    if (num == 1)
    {
        Console.WriteLine($"{num}\"\n");
        return;
    }
    else
    {
        Console.Write($"{num}, ");
    }

    DumberDigits(--num);
}

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int m = 1;
n = 15;
System.Console.WriteLine($"Сумму натуральных элементов в промежутке от {m} до {n}.");
System.Console.WriteLine($"M = {m}; N = {n} -> {RangeSum(m, n)}\n");

int RangeSum(int of, int to) => of == to ? to : of + RangeSum(++of, to);


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

m = 3;
n = 2;
System.Console.WriteLine($"Функция Аккермана A({m}, {n})");
System.Console.WriteLine($"m = {m}, n = {n} -> A({m}, {n}) = {Ackermann(m, n)}\n");

int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;

    else if (n == 0) return Ackermann(m - 1, 1);

    else return Ackermann(m - 1, Ackermann(m, n - 1));
}