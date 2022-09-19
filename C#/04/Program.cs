// Напишите программу, которая на вход принимает одно число, а на выходе показывает все целые числа 
// от -N до N
// 4-> -4, -3, -2, -1, 0, 1, 2, 3, 4

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
int i = a*-1;
while (i <= a)
{
    Console.WriteLine(i);
    i = i + 1;
}