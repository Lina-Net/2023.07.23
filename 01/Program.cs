// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами


void InputArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10001);
            matrix[i, j] = Convert.ToDouble(matrix[i, j]/100);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }

}


Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
double[,] matrix = new double[size[0], size[1]];
InputArray(matrix);