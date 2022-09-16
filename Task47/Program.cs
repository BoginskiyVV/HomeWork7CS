// Задача 47. 
// Задайте двумерный массив размером m?n, заполненный случайными вещественными числами.

Console.Write("Задайте количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] Array = new double[m, n];
Random num = new Random();

void FillArray(double[,] matrix)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = Convert.ToDouble(num.Next(-15, 15) / 10.0);
        }
    }
}

void PrintArray(double[,] matrix)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

FillArray(Array);
PrintArray(Array);