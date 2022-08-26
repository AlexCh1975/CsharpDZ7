/*
    Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
    арифметическое элементов в каждом столбце.

    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

 Console.Clear();

int[,] array = CreateTwoDimensionalArray();
double[] averageArray = GetAverageColumnsArray(array);
PrintTwoDimensionalArray(array, averageArray);

int[,] CreateTwoDimensionalArray()
{
    int[,] array = new int[3,4];
    int rows = array.GetUpperBound(0) +1; 
    int columns = array.Length / rows;

    for (int i = 0; i < rows; i++) 
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(0, 100);
        }
    }
    return array;
}

double[] GetAverageColumnsArray(int[,] array)
{
    int rows = array.GetUpperBound(0) +1; 
    int columns = array.Length / rows;

    double[] averageArray = new double[columns];

    for (int j = 0; j < columns; j++) 
    {
        double sum = 0;
        for (int i = 0; i < rows; i++)
        {
            sum += array[i,j];
        }
        averageArray[j] = Math.Round((sum / rows), 2);
    }
    return averageArray;
}

void PrintTwoDimensionalArray(int[,] array, double[] averageArray)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("[ ");
    int rows = array.GetUpperBound(0) +1; 
    int columns = array.Length / rows;

    for (int i = 0; i < rows; i++) 
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"\t{array[i, j]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine("]");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Среднее арифметическое столбцов массива:");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Red;
    for (int i = 0; i < averageArray.Length; i++) 
    {
       if(i == averageArray.Length -1) Console.Write($"\t{averageArray[i]}");
       else Console.Write($"\t{averageArray[i]};");
    }
    Console.WriteLine();
    Console.ResetColor();
}