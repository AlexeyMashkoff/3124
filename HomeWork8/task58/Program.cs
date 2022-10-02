// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Например, заданы 2 массива:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// и

// 1 5 8 5

// 4 9 4 2

// 7 2 2 6

// 2 3 4 7

// Их произведение будет равно следующему массиву:

// 1 20 56 10

// 20 81 8 6

// 56 8 4 24

// 10 6 24 49

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = 1, int rightRange = 9)
{
    int[,] matrix = new int[rowsCount, columnsCount];

    Random rand = new Random();

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}
int[,] Multi(int[,] matrix, int[,]matrix2)
{
    int[,] matrix3 = new int[matrix.GetLength(0), matrix2.GetLength(1)];

if (matrix.GetLength(0) == matrix2.GetLength(0) || matrix.GetLength(1) == matrix2.GetLength(1) )

for (int i = 0; i < matrix3.GetLength(0); i++)
{
    for (int j = 0; j < matrix3.GetLength(1); j++)
    {
            matrix3[i, j] = matrix[i, j] * matrix2[i, j];
        }
    }
     return matrix3;
}

int m = ReadNumber("Введите количество строк для первой матрицы");
int n = ReadNumber("Введите количество столбцов для первой матрицы");
int[,] matr = GetMatrix(m, n);
PrintMatrix(matr);
Console.Write("\n");
int[,] matr2 = GetMatrix(m, n);
PrintMatrix(matr2);
Console.Write("\n");
PrintMatrix(Multi(matr, matr2));

