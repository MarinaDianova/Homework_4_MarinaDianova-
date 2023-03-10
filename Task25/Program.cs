// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetNumber(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Power(int A, int B)
{
    int result = 1;
    for (int i = 1; i <= B; i++)
    {
        result = result * A;
    }
    return result;
}

bool ValidateExp(int exp)
{
    if (exp < 0)
    {
        System.Console.WriteLine("Показатель степени должен быть больше нуля!");
        return false;
    }
    return true;
}

int numA = GetNumber("Введите число A (число, возводимое в степень): ");
int numB = GetNumber("Введите число B (показатель степени): ");

if (ValidateExp(numB))
{
    System.Console.WriteLine($"{numA} в степени {numB} = {Power(numA, numB)}");
}