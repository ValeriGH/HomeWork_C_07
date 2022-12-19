// Программа на вход принимает позиции элемента в двумерном массиве
// и возвращает значение этого элемента или указывает, что такого элемента нет

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


Console.Clear();
int n = new Random().Next(1, 11);
int m = new Random().Next(1, 11);
Console.WriteLine($"Матрица размером {n} x {m}:");
int[,] array = new int[n, m];
InputArray(array);
Console.Write("Введите позицию искомого элемента: ");
int[] pos = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();
if (pos[0] <= n && pos[1] <= m)
    Console.WriteLine($"\nВаш элемент: {array[pos[0] - 1, pos[1] - 1]}");
else
    Console.Write("такой позиции нет");