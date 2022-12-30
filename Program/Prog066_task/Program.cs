// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите значение М: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
int SumRec(int n)
{
    if(n == m) return m;
    else return n + SumRec(n - 1);
}
Console.WriteLine("Сумма элементов в промежутке от M до N = "+SumRec(n));