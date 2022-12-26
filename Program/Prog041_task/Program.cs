
Console.Write("Сколько чисел хотите ввести? - ");
int numbers = int.Parse(Console.ReadLine());
int[] array = new int[numbers];
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"\nВведите число с индексом {i}: ");
    array[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("\nВывод чисел и ->  количество чисел больше 0 \n");
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i]+ ", ");
    if(array[i] > 0) count = count + 1;
}
Console.Write( " ->  " +count+ "         \n "  );


















// void FillArray(int[] collection);
// {
//     int size = collection.Length;
//     int i = 0;
//     while (i < size)
//     {
//         collection[i] = new Array[];
//         i++;
//     }
// }

// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int pos = 0;
//     while (pos < count)
//     {
//         Console.Write(col[pos] + " ");
//         pos++;
//     }
// }
// Console.WriteLine("Введите ");
// FillArray(array);
// PrintArray(array);