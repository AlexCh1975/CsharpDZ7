/*
    Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
    m = 3, n = 4.

    0,5 7 -2 -0,2
    1 -3,3 8 -9,9
    8 7,8 -7,1 9
*/

Console.Clear();

double[,] array = CreateTwoDimensionalArray();
PrintTwoDimensionalArray(array);

double[,] CreateTwoDimensionalArray()
{
    double[,] array = new double[3,4];
    int rows = array.GetUpperBound(0) +1; 
    int columns = array.Length / rows;

    for (int i = 0; i < rows; i++) 
    {
        for (int j = 0; j < columns; j++)
        {
            int range = new Random().Next(-99, 100);
            array[i,j] = Math.Round((new Random().NextDouble() * range), 2);
        }
    }
    return array;
}

void PrintTwoDimensionalArray(double[,] array)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("[ ");
    int rows = array.GetUpperBound(0) +1; 
    int columns = array.Length / rows;

    for (int i = 0; i < rows; i++) 
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"\t{array[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine("]");
    Console.ResetColor();
}