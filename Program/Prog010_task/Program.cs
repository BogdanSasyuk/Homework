//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите три трехзначных числа ");
int A = Convert.ToInt32(Console.ReadLine()); 
int B = Convert.ToInt32(Console.ReadLine()); 
int C = Convert.ToInt32(Console.ReadLine()); 
  if(A > 99 && A < 1000)
  {
        Console.WriteLine(A.ToString()+" => "+A.ToString()[1]);
  } 
  if(B > 99 && A < 1000)
  {
        Console.WriteLine(B.ToString()+" => "+B.ToString()[1]);
  } 
  if(C > 99 && A < 1000)
  {
        Console.WriteLine(C.ToString()+" => "+C.ToString()[1]);
  } 

 