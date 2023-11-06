// Перевод числа из десетичной системы в любую другую
//100 23 44
int number = 26;
int system = 3;
string[] system16 = new string[] { "A", "B", "C", "D", "E", "F" };

Console.Clear();
string newNumberSystem = "";
for (int i = 1; i <= number; i++)
{
    newNumberSystem = converter(i, system);
    Console.WriteLine($"( {i} ) в ( 10 ) -> ( {newNumberSystem} ) в ( {system} )");
}

// string newNumberSystem = converter(number, system);

// Console.WriteLine($"\n( {number} ) в ( 10 ) -> ( {newNumberSystem} ) в ( {system} )");

// string ReversNumberSystem = ReverseConversion(newNumberSystem, system);

// Console.WriteLine($"\nЧисло ( {newNumberSystem} ) в ( {system} ) системе исчесления равно числу ( {ReversNumberSystem} ) в ( 10 ) системе исчесления\n");

string converter(int number, int system)
{
    int temp = 0;
    string result = "";
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
    return result;

}

string ReverseConversion(string numb, int system)
{
    int result = 0;
    int count = numb.Length - 1;
    string num = "";

    for (int i = 0; i < numb.Length; i++)
    {
        num = numb[i].ToString();
        result += Convert.ToInt32(num) * Exponentiation(system, count--);
    }

    return $"{result}";
}

int Exponentiation(int number, int pow)
{
    int result = number;
    if (pow == 0)
    {
        number = 1;
    }
    else
    {
        for (int i = 0; i < pow - 1; i++)
        {
            number *= result;
        }
    }
    return number;
}
