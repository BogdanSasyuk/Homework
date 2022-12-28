// Задача 23:
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число - ");
int N = Convert.ToInt32(Console.ReadLine());
void kub(int[] N)
{
  int index = 0;
  int length = N.Length;
  while (index <  length)
  {
    N[index] = Convert.ToInt32(Math.Pow(index, 3));
    index++;
  }
}
void PrintArray(int[] collection)
{
  int count = collection.Length;
  int position = 1;
  while(position < count)
  {
    Console.Write(collection[position]+ "  ");
    position++;
  }
} 
int[] array = new int[N + 1];
kub(array);
PrintArray(array);