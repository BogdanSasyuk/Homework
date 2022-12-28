//Задача 5:  Показать последнюю цифру трёхзначного числа.
  
Console.WriteLine("Введите трехзначное число ");
int A = Convert.ToInt32(Console.ReadLine()); 

  if(A > 99)
  {
        Console.WriteLine("Третья цифра в числе  "+A.ToString()+" = "+A.ToString()[2]);
  } 
  
 
