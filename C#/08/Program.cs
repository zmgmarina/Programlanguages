﻿// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 16, 4 -> кратно

Console.Write("Введите первое число: ");
int firstnumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondtnumber = Convert.ToInt32(Console.ReadLine());

if (firstnumber % secondtnumber == 0)
{
   Console.WriteLine("Числа кратные");
}
else  Console.WriteLine($"Числа не являются кратными");
Console.WriteLine($"Остаток от деления {firstnumber} на {secondtnumber} = {firstnumber % secondtnumber}");



