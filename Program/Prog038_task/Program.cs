// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] array = new int[5];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-99, 99);
}
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    if(i == array.Length - 1)
    {
        Console.Write(array[i]+ "]     ");
    }
    else
    {
        Console.Write(array[i]+ ", ");
    } 
}
int diff = 0;
int min = array[0];
int max = array[0];
for (int i = 0; i < array.Length; i++)
{
    if(array[i] < min)
    {
        min = array[i];        
    }
    else if(array[i] > max)
    {
        max = array[i];
    }
    diff = max - min;
}
Console.WriteLine("Разность между max и min -> " +diff);