
Console.WriteLine("Введите число - ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа - ");
int B = Convert.ToInt32(Console.ReadLine());
int num = 1;
for (int i = 1; i <= B ; i++)
{
    num = num * A;
}
Console.WriteLine(A+ "^"+B+" -> "+num); 