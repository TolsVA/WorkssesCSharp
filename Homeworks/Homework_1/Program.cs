// Перевод числа из десетичной системы в любую другую
//100 23 44
int number = 9;
int system = 2;
int pref = 0;
int next = 0;
int temp = 0;
string[] system16 = new string[] { "A", "B", "C", "D", "E", "F" };

Console.Clear();
string newNumberSystem = "";
for (int i = 0; i <= number; i++)
{
    newNumberSystem = NewResult(converter(i, system));

    temp = Convert.ToInt32(newNumberSystem);


    if(Compare(newNumberSystem)){
        // Compare(newNumberSystem);
        Console.Write($"Текущее = {newNumberSystem}  Pref = {pref}");
        next = temp - pref;
        pref = temp;
        System.Console.WriteLine($" Разница = {next}");

    }
    // Console.WriteLine($"( {i} ) в ( 10 ) -> ( {newNumberSystem} ) в ( {system} )");
}

string NewResult(string result)
{
    while (result.Length < system)
    {
        result = 0 + result;
    }

    return result;
}

bool Compare(string nums)
{
    int[] sum = new int[10];

    for (int i = 0; i < nums.Length; i++)
    {
        if (++sum[Convert.ToInt32(nums[i].ToString())] > 1) return false;
    }

    return true;
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
