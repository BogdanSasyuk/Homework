// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
       Console.Write(" "+array[i, j] + "  "); 
    }
    Console.WriteLine();
}

int minSumLine = 0;
int sumLine = SumElementsLine(array, 0);
int SumElementsLine(int[,] array, int i)
{
  int sumLine = array[i, 0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i, j];
  }
  return sumLine;
}
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSumLine = SumElementsLine(array, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}
Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой элементов = {sumLine} ");

