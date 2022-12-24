
Console.WriteLine("Введите число - ");
int A = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (A > 0)
{
    sum = sum + A % 10;
    A = A / 10;
}
Console.WriteLine( "->  " +sum);