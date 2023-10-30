Console.WriteLine("Для решения данного домашнего задания вам необходимо воспользоваться сервисом автоматической проверки написанного кода на сайте gb в личном кабинете на странице домашнего задания к уроку");
System.Console.WriteLine(factorial(4));
int factorial(int n) { if (n == 1) return 1; else return n * factorial(n - 1); }