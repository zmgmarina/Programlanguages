// 
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 == number2 * number2)
{
    Console.Write("Первое число является квадратом второго числа");
}
else
{
  Console.Write("Первое число не является квадратом второго числа");
}
