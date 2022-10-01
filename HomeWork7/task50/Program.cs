// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1 7 -> такого числа в массиве нет


int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
void FillArray(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1, 10);
        }
    }
}
void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j]+ " ");
        }
        Console.WriteLine();
    }
}
int[,] matrix = new int[4,6]; 
int m = ReadNumber("Введите индекс строки"); 
int n = ReadNumber("Введите индекс столбца");
void Number(int[,] matrix)
{
    if (m < matrix.GetLength(0) && n < matrix.GetLength(1))
{ 
    Console.WriteLine(matrix[m, n]);
}
else 
{
    Console.WriteLine($"{m}{n} -> такого числа в массиве нет");
}
}
FillArray(matrix);
PrintMatrix(matrix);
Number(matrix);