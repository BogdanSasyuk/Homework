//Задача 8: Удалить вторую цифру трёхзначного числа.


  
Console.WriteLine("Введите трехзначное число ");
int A = Convert.ToInt32(Console.ReadLine()); 
string B = A.ToString();
  if(A > 99)
  {
        B = B.Remove(1, 1);
        Console.WriteLine("Удалил вторую цифру получили - "+B);
  } 
  
  


  