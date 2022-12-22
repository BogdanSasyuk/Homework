
Console.WriteLine("Введите координаты x, y, z точки А ");
Console.WriteLine("Введите координаты x, y, z точки B ");
double x1 = Convert.ToInt32(Console.ReadLine());
double y1 = Convert.ToInt32(Console.ReadLine());
double z1 = Convert.ToInt32(Console.ReadLine());
double x2 = Convert.ToInt32(Console.ReadLine());
double y2 = Convert.ToInt32(Console.ReadLine());
double z2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты x, y, z точки А ");
Console.WriteLine("Введите координаты x, y, z точки B ");
double x3 = Convert.ToInt32(Console.ReadLine());
double y3 = Convert.ToInt32(Console.ReadLine());
double z3 = Convert.ToInt32(Console.ReadLine());
double x4 = Convert.ToInt32(Console.ReadLine());
double y4 = Convert.ToInt32(Console.ReadLine());
double z4 = Convert.ToInt32(Console.ReadLine());

double AB = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
double AB1 = Math.Sqrt(Math.Pow(x4 -x3, 2) + Math.Pow(y4 - y3, 2) + Math.Pow(z4 - z3, 2));
Console.WriteLine("Расстояние между точками А и В по заданным координатам  ->  " +AB);
Console.WriteLine("Расстояние между точками А и В по заданным координатам  ->  " +AB1);