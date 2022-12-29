// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


Console.WriteLine("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine()); 
int[,] array = new int[n, m];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
    }
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
       Console.Write(array[i, j] + " "); 
    }
    Console.WriteLine();
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int h = 0; h < array.GetLength(1) - 1; h++)
        {
            if (array[i, h] < array[i, h + 1])
            {
                int temp = array[i, h + 1];
                array[i, h + 1] = array[i, h];
                array[i, h] = temp;
            }
        }
    }
}

Console.WriteLine($"\nУпорядоченный по убыванию массив: ");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int h = 0; h < array.GetLength(1); h++)
    {
       Console.Write(array[i, h] + " "); 
    }
    Console.WriteLine();
}

