// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите трехзначное число ");
int A = Convert.ToInt32(Console.ReadLine()); 

  if(A > 99)
  {
        Console.WriteLine("Вторая цифра в числе  "+A.ToString()+" = "+A.ToString()[1]);
  } 
  
