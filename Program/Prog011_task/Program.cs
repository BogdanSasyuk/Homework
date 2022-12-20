
Console.WriteLine("Введите три числа ");
int A = Convert.ToInt32(Console.ReadLine()); 
int B = Convert.ToInt32(Console.ReadLine()); 
int C = Convert.ToInt32(Console.ReadLine()); 
 if(A > 99 && A < 1000)
 {
    Console.WriteLine(A.ToString()+"   -> "+A.ToString()[2]);
 } 
 if(B > 9 && B < 100)
 {
    Console.WriteLine(B.ToString()+"    -> Третьей цифры нет! ");
 }
      
  
 if(C > 9999 && C < 100000)
 {
    Console.WriteLine(C.ToString()+" -> "+C.ToString()[2]);
 }
