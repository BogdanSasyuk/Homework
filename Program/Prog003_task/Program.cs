//Задача 3:Найти максимальное из трех чисел.

int A = 0;
int B = 0;
int C = 0;
Console.Write("");
A = Convert.ToInt32(Console.ReadLine());
Console.Write("");
B = Convert.ToInt32(Console.ReadLine());
Console.Write("");
C = Convert.ToInt32(Console.ReadLine());
int max = A;
    if(A > max) max = A;
    if(B > max) max = B;
    if(C > max) max = C;
Console.WriteLine(max);
