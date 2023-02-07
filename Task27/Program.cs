// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

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