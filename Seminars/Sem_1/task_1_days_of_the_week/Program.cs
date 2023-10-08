using System.ComponentModel.DataAnnotations;
string[] den = {"Понедельник", "Вторник", "Среда", "Четверг", 
"Пятница", "Субота", "Воскресенье"};
System.Console.WriteLine(den[Convert.ToInt32(Console.ReadLine()) -1]);