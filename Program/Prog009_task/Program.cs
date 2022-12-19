// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите первое число ");
int A = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите второе число ");
int B = Convert.ToInt32(Console.ReadLine()); 

int ost = A % B;
    if(ost == 0)
    {
        Console.WriteLine("Число А кратно числу В ");
    }
    else
    {
        Console.WriteLine("Выводим остаток - "+ost % 10);
    } 

