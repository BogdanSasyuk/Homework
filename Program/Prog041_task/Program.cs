
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

