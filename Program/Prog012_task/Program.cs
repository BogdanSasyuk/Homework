//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру соответствующую дню недели ");
int A = Convert.ToInt32(Console.ReadLine()); 
int B = Convert.ToInt32(Console.ReadLine()); 
int C = Convert.ToInt32(Console.ReadLine()); 
  if(A == 6)
  {
        Console.WriteLine(A.ToString()+" ->  да ");
  } 
  if(B == 7)
  {
        Console.WriteLine(B.ToString()+" ->  да ");
  } 
  if(C == 1)                                              //(C > 0 && C < 6)
  {
        Console.WriteLine(C.ToString()+" ->  нет ");
  } 
