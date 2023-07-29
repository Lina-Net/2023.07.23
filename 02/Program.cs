//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

Console.Write("Введите размер матрицы через пробел: "); 
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputArray(matrix);
Console.Write("Введите позиции элемента: "); 
Console.Write("m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());

void InputArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = new Random().Next(0, 10);
                Console.Write($"{matrix[i, j]} \t");
            }
            Console.WriteLine();
    }
}


void Element ()
{
    if (m > matrix.GetLength(0) || n > matrix.GetLength(1))
                Console.WriteLine("Такого элемента нет");

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (m==i && n==j)
            Console.WriteLine($"Элемент заданной позиции {matrix[m, n]}");                     
        }
    }
    
}


Element();
