
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

