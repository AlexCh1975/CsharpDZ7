/*
    Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
    двумерном массиве, и возвращает значение этого элемента или же указание, что 
    такого элемента нет.(на вход именно поступает позиция элемента, можете разбить 
    на две переменные или прописать в одну строку и конвертировать в два числа, 
    комментарии в конце семинара по этой задаче)

    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    17 -> такого числа в массиве нет
*/

//Console.Clear();

Console.Write("Введите первую позицию элемента в массиве (в строке): ");
int rowsIndex = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите вторую позицию элемента в массиве (в колонке): ");
int columnsIndex = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateTwoDimensionalArray();
int result = IsElementArray(array, rowsIndex, columnsIndex);
PrintTwoDimensionalArray(array, result, rowsIndex, columnsIndex);

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

int IsElementArray(int[,] array, int rowsIndex, int columnsIndex)
{
    int rows = array.GetUpperBound(0) +1; 
    int columns = array.Length / rows;

    for (int i = 0; i < rows; i++) 
    {
        for (int j = 0; j < columns; j++)
        {
            if (i == rowsIndex && j == columnsIndex) return array[i,j];
        }
    }
    return -1;
}

void PrintTwoDimensionalArray(int[,] array, int result, int rowsIndex, int columnsIndex)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("[ ");
    Console.ResetColor();

    int rows = array.GetUpperBound(0) +1; 
    int columns = array.Length / rows;

    for (int i = 0; i < rows; i++) 
    {
        for (int j = 0; j < columns; j++)
        {
            if (i == rowsIndex && j == columnsIndex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"\t{array[i, j]}");
                Console.ResetColor();
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"\t{array[i, j]}");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine("]");
    if (result == -1) Console.WriteLine($"array[{rowsIndex},{columnsIndex}] нет такой позиции в этом массиве!");
    else Console.WriteLine($"На позиции array[{rowsIndex},{columnsIndex}] -> {result}");
    Console.ResetColor();
}