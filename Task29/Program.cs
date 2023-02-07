// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
// 6, 1, 33 -> [6, 1, 33]

int GetNumber(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}

int[] FillArray(int size, int leftRange, int rightRange)
{
    int[] arrN = new int[size];
    for (int i = 0; i < size; i++)
    {
        arrN[i] = new Random().Next(leftRange, (rightRange + 1));
    }
    return arrN;
}

int size = GetNumber("Введите размер массива: ");
int min = GetNumber("Введите левую границу генерации чисел: ");
int max = GetNumber("Введите правую границу генерации чисел: ");

int[] myArray = FillArray(size, min, max);
PrintArray(myArray);