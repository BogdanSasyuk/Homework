// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[4];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100, 100);
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

int count = 0;
for (int i = 1; i < array.Length; i = i + 2)
{
    count += array[i]; 
}
Console.WriteLine("Cумма элементов на нечетных позициях -> "+count);