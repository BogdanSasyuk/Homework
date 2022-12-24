
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 10);
}
for (int i = 0; i < array.Length; i++)
{
    if(i == array.Length - 1)
    {
        Console.Write(array[i]+ ".    ");
    }
    else
    {
        Console.Write(array[i]+ ", ");
    } 
}