// Задача 50. Напишите программу, которая на вход принимает число,
//  и возвращает индексы числа в двумерном массиве или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine()); 
double[,] array = new double[n,m];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(1,10);
    }
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
       Console.Write(" "+array[i,j] + "\t  "); 
    }
    Console.WriteLine();
}
Console.WriteLine("\n Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
bool isInArray = false;
int count = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
       if(array[i,j] == number)
       {     
        isInArray = true;
        count++;
       }
    }
    
}
if(isInArray)
{
    Console.WriteLine($"Число {number} есть в массиве и встречается там {count} раз(а).");
}
else
{
    Console.WriteLine($"Числа {number} нет в массиве ");
}

