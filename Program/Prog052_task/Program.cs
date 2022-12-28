
Console.WriteLine("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine()); 
double[,] array = new double[n, m];
double[] middle = new double[m];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 20);
    }
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
       Console.Write(" "+array[i, j] + "\t"); 
    }
    Console.WriteLine();
}
for (int i = 0; i < array.GetLength(1); i++)
{
    for (int j = 0; j < array.GetLength(0); j++)
    {
        middle[i] += array[j, i] / n;
        middle[i] = Math.Round(middle[i], 1);
    }
    Console.WriteLine($"Среднее арифметическое элементов столбца {i + 1}  =  {middle[i]}");
}
