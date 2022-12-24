
int[] array = new int[5];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 10);
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
int j = array.Length - 1;
for ( int i = 0; i < (array.Length + 1) / 2; i++ )
{
    if(i == j) Console.Write(array[i] + "  ");
    else       Console.Write(array[i] * array[j]+ "   ");
    j--;
}
