// Задача 58: Задайте два двумерных массива (от 0 до 10). Напишите программу, которая будет находить произведение двух массивов (поэлементное).
// Например, даны 2 массива:
// 2 4
// 3 2

// 3 4
// 3 3
// Результирующая матрица будет:
// 6 16
// 9 6

void FillArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            collection[i, j] = new Random().Next(1, 11);
        }
    }
}

void PrintArray(int[,] col)
{
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int j = 0; j < col.GetLength(1); j++)
        {
            Console.Write($"{col[i, j]}  ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите размеры первого массива: ");
Console.WriteLine("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размеры второго массива: ");
Console.WriteLine("Введите количество строк: ");
int p = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int h = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[n, m];
int[,] arr = new int[p, h];
FillArray(array);
PrintArray(array);
Console.WriteLine();
FillArray(arr);
PrintArray(arr);
int[,] resultArray = new int[n, h];
for (int i = 0; i < resultArray.GetLength(0); i++)
{
    for (int j = 0; j < resultArray.GetLength(1); j++)
    {
        int product = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            product = array[i, j] * arr[i, j];
        }
        resultArray[i, j] = product;
    }
}
Console.WriteLine();
PrintArray(resultArray);
