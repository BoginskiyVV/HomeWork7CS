// Задача 52
// Задайте двумерный массив из целых чисел. Найдите среднее
// арифметическое элементов в каждом столбце.

Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
FillArray(array);
Console.Write("Cреднее арифметическое в каждом столбце: ");
FindArithmeticMean(array);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = Convert.ToInt32(new Random().Next(0, 10));
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i, j] + "\t  ");
        Console.WriteLine();
    }
}

void FindArithmeticMean(int[,] array)
{
    // double arithmeticM = 0;
    // Console.Write("Cреднее арифметическое в каждом столбце: ");
    // Console.Write("CA: ");

    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0; 
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        Console.Write($"{sum / array.GetLength(0)}  ");
    }

}