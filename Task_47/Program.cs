// Заполнить двумерный массив вещественными числами

void InputMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
           {
            matrix[i,j] = Math.Round(new Random().NextDouble() * 100, 2);
            Console.Write($"{matrix[i, j]} \t");  
            }
        Console.WriteLine();       
    }
}

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int[] size = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();
double[,] matrix = new double[size[0], size[1]];
InputMatrix(matrix);
