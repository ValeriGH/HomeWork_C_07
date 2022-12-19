// Задана целочисленная матрица, состоящая из N строк и M столбцов. 
// Требуется транспонировать ее относительно горизонтали.

Console.Clear();
// Задать двумерный массив целых чисел
// Найти среднее арифметическое столбцов

void InputArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 101);
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void TransponirHorisontal(int[,] matrix)
{
    for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
int n = new Random().Next(2, 6);
int m = new Random().Next(2, 6);
Console.WriteLine($"Матрица размером {n} x {m}:");
int[,] matrix = new int[n, m];
InputArray(matrix);
Console.WriteLine($"Транспонированная матрица:");
TransponirHorisontal(matrix);
