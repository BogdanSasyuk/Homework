//Задача 2: По заданному номеру дня недели вывести его название.

int N = 0;
N = Convert.ToInt32(Console.ReadLine());
    if(N == 1)
       Console.WriteLine("Понедельник "); 
    if(N == 2)
       Console.WriteLine("Вторник ");
    if(N == 3)
       Console.WriteLine("Среда "); 
    if(N == 4)
       Console.WriteLine("Четверг "); 
    if(N == 5)
       Console.WriteLine("Пятница "); 
    if(N == 6)
       Console.WriteLine("Суббота "); 
    if(N == 7)
       Console.WriteLine("Воскресенье "); 
    if(N > 7)
       Console.WriteLine("В неделе всего 7 дней!!! "); 

