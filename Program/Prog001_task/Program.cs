int A = 0;
int B = 0;
Console.Write("Введите число А - ");
A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В - ");
B = Convert.ToInt32(Console.ReadLine());
    if(B == A * A)
    {
        Console.WriteLine("Число В является квадратом числа А ");
    }
    else
    {
        Console.WriteLine("Число В не является квадратом числа А ");
    }