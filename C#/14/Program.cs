// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B(2,1) -> 5,09
// A (7,-5); B(1,-1) -> 7,21
// формула d = √ [(x 2 -x 1) 2 + (y 2 -y 1)]

Console.Write("Введите координату x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

//Math.Sqrt(25) => 25
//Math.Pow (число,степень) => Math.Pow (5,2) => 25
//Math.Round(1.756,2) => 1.8  Round - функция для округления (цифра 2 - это две цифры после запятой) 
 
double d = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2));
Console.WriteLine($"Расстояние между точками: {Math.Round(d,3)}");




