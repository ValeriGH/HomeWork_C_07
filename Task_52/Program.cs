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
}

void Solution(int[,] matrix)
{
    Console.WriteLine("\nСреднее арифметическое столбцов: ");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i,j];
        }
        Console.Write($"{sum/matrix.GetLength(0)}\t");
    }
}

Console.Clear();
int n = new Random().Next(1, 6);
int m = new Random().Next(1, 6);
Console.WriteLine($"Матрица размером {n} x {m}:");
int[,] matrix = new int[n, m];
InputArray(matrix);
Solution(matrix);
