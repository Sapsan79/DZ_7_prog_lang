//Задача 52.Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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
        Console.WriteLine("Среднеарифметическая сумма каждого столбца равна");
    for (int j = 0; j < Array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < Array.GetLength(0); i++)
        {
            sum += Array[i, j];
        }
        Console.Write($"{sum / (Array.GetLength(0))}; ");
    }
    Console.ReadLine();
}
    Task();
void Task()
{
    int[,] Array = inputTwoDimensionArray(ReadInt(), ReadInt());
    GetArrayAsString(Array);
}

