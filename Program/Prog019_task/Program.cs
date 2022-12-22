
Console.WriteLine("Введите пятизначное число для проверки, является ли оно палиндромом ");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int C = Convert.ToInt32(Console.ReadLine());

if(A.ToString()[0] != A.ToString()[4])
{
  Console.WriteLine(A.ToString()+" -> нет "); 
}
else
if(A.ToString()[..4] == A.ToString()[..4])
{
  Console.WriteLine(A.ToString()+" -> да ");
}    
if(B.ToString()[0] != B.ToString()[4])
{
  Console.WriteLine(B.ToString()+" -> нет "); 
}
else
if(B.ToString()[..4] == B.ToString()[..4])
{
  Console.WriteLine(B.ToString()+" -> да ");
} 
 if(C.ToString()[0] != C.ToString()[4])
{
  Console.WriteLine(A.ToString()+" -> нет "); 
}
else
if(C.ToString()[..4] == C.ToString()[..4])
{
  Console.WriteLine(C.ToString()+" -> да ");
} 
  
