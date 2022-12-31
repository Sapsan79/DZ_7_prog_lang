//Задача 47.Задайте двумерный массив размером m×n,
//заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 - 2 - 0,2
//1 - 3,3 8 - 9,9
//8 7,8 - 7,1 9
double[,] inputTwoDimensionArray(int length, int secondLength)
{
    double[,] Array = new double[length, secondLength];
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

void FillDimension(int index, double[,] Array)
{
    for (int i = 0; i < Array.GetLength(1); i++)
    {
        Array[index, i] = new Random().NextDouble() * 100;

        //Array[index, i] = Math.Round (new Random().NextDouble()*100,2);//ограничение по двум символам после запятой
    }
}
void GetArrayAsString(double[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            //Console.Write($"{Array[i, j]} ");
            Console.Write(string.Format("{0:0.##} ", Array[i, j]));//ограничение на 2 символа
        }
        Console.WriteLine();
    }
}
Task();
void Task()
{
    double[,] Array = inputTwoDimensionArray(ReadInt(), ReadInt());
    GetArrayAsString(Array);
}
