//Задача 7: Дано число из отрезка [10, 99]. Показать наибольшую цифру числа.

Console.WriteLine("Введите двухзначное число ");
int n = int.Parse(Console.ReadLine()!);
     if(n >9 && n <100)
     {
          if(n / 10 > n % 10)
             Console.WriteLine("Первая цифра больше ");   
          else if(n / 10 == n % 10)
             Console.WriteLine("Цифры одинаковы ");
          else
             Console.WriteLine("Bторая цифра больше ");
     }  
     else
     {
        Console.WriteLine("Число не является двузначным ");
     }   