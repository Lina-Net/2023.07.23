// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите размер матрицы через пробел: "); 
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputArray(matrix);
double average = 0;



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

void Average (double average)
{    
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        average = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            average = average + matrix[i,j];                    
        }
       Console.Write((average/ matrix.GetLength(0)) + "; ");    
    } 
    
}

Average (average);









