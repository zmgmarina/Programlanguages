/*Напишите программу, которая принимает на вход координаты точки (x, y), причем х ≠ 0 и y ≠ 0
/* выдает четверть плоскости в которой находится эта точка

 "&&" - и
 "||" - или

*/
Console.WriteLine("Введите координату по оси x: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату по оси y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0) Console.WriteLine("I четверть");
else if (x < 0 && y > 0) Console.WriteLine("II четверть"); // else if прим-м, чтобы не проверять все усл, а найти одну истину и заверш проверку 
else if (x < 0 && y < 0) Console.WriteLine("III четверть");  
else if (x > 0 && y < 0) Console.WriteLine("IV четверть");  