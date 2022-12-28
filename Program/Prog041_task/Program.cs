// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Пример:
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Сколько чисел хотите ввести? - ");
int numbers = Convert.ToInt32(Console.ReadLine());
int[] array = new int[numbers];
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"\nВведите число с индексом {i}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("\nВывод чисел и ->  количество чисел больше 0 \n");
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i]+ ", ");
    if(array[i] > 0) count = count + 1;
}
Console.Write( " ->  " +count+ "         \n "  );

