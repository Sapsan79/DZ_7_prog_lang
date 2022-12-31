// Задача 50. Напишите программу, которая на вход принимает позиции элемента в
// двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17->такого числа в массиве нет
int[,] inputTwoDimensionArray(int length, int secondLength)
{
    int[,] Array = new int[length, secondLength];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        FillDimension(i, Array);
    }
    return Array;
}

int ReadInt()
{
    Console.WriteLine("input number");
    int a = int.Parse(Console.ReadLine());
    return a;
}

void FillDimension(int index, int[,] Array)
{
    for (int i = 0; i < Array.GetLength(1); i++)
    {
        Array[index, i] = new Random().Next(1, 10);
    }
}
void GetArrayAsString(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j]}");
        }
        Console.WriteLine();
    }
}
Task();
void Task()
{
    int[,] Array = inputTwoDimensionArray(ReadInt(), ReadInt());
    GetArrayAsString(Array);
    Console.WriteLine("Введите индекс строки элемента m: ");
    int m = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите индекс столбца элемента n: ");
    int n = int.Parse(Console.ReadLine());
    if (n < Array.GetLength(0) && n < Array.GetLength(1))
        Console.WriteLine($"Элемент массива с индексом [m,n] равен: {Array[m, n]}");
    else
    {
        Console.WriteLine("Такого элемента не существует");
    }
}
