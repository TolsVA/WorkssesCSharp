using System.Dynamic;
Console.WriteLine("Введите имя пользователя!");
string? name = Console.ReadLine();

if(name?.ToLower() == "masha") { // name.ToLower() Переводит све символы в нижний регистр
    System.Console.WriteLine("Ура это же МАША"); 
} else {
    System.Console.WriteLine($"Привет {name}");
}

