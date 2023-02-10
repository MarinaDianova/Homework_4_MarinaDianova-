// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// ВАРИАНТ 1. ТЕКСТОВЫЙ

string? GetNumber(string text)
{
    System.Console.Write(text);
    return Console.ReadLine();
}

int SumLength(string x)
{
    int len = x.Length;
    int result = 0;
    for (int i = 0; i < len; i++)
    {
        char ch = x[i];
        result = result + Convert.ToInt32(Char.ToString(ch));

    }
    return result;
}

string? num = GetNumber("Введите число: ");

if (int.TryParse(num, out int number))
{
    Console.WriteLine($"Сумма цифр чмсла {num} = {SumLength(num)}");
}
else
{
    System.Console.WriteLine("Введено не число!");

}


// ВАРИАНТ 2. МАТЕМАТИЧЕСКИЙ
// int GetNumber(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int SumAllDigits(int number)
// {
//     int result = 0;
//     while(number>0)
//     {
//         result+= number%10;
//         number=number/10;
//     }
//     return result;
// }

// int num = GetNumber("Введите число: ");

// Console.WriteLine($"Сумма цифр чмсла {num} = {SumAllDigits(num)}");