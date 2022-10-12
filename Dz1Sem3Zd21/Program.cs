// Программа, принимает координаты двух точек и находит расстояние между ними.

Console.WriteLine("Вы хотите определить расстояние между точками А и В?"); 

Console.WriteLine("Введите координату х точки А:"); 
double xa = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату y точки А:"); 
double ya = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату z точки А:"); 
double za = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату х точки B:"); 
double xb = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату y точки B:"); 
double yb = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату z точки B:"); 
double zb = double.Parse(Console.ReadLine()!);

double resalt1 = xb -xa;
   double resalt2 = resalt1 * resalt1;

double resalt3 = yb -ya;
   double resalt4 = resalt3 * resalt3;

double resalt5 = zb -za;
double resalt6 = resalt5 * resalt5;

   double resalt =  resalt2 +  resalt4 + resalt6;
   double AB = Math.Sqrt(resalt);

   
      //double AB = Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((yb - ya), 2));

 Console.WriteLine($"Расстояние между точками А и В = {AB:f2} км.");

