
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