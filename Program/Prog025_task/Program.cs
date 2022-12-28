// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Не используя Math.Pow!
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

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