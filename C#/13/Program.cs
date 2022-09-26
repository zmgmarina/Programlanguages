// Напишите программу, которая по заданому номеру четверти показывает диапазон координат точек в этой четверти (х и y)

Console.WriteLine("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());

if (quarter == 1) Console.WriteLine("x > 0 && y > 0");
else if (quarter == 2) Console.WriteLine("x < 0  y > 0");  
else if (quarter == 3) Console.WriteLine("x < 0  y < 0");  
else if (quarter == 4) Console.WriteLine("x > 0  y < 0"); 
else Console.WriteLine("error 404, quarter not found"); // все четверти кроме 1234