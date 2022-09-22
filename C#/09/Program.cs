// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23. 14 -> нет 46 -> нет 161 -> да

int value = Convert.ToInt32(Console.ReadLine());

if (value % 7 == 0 && value % 23 == 0)
Console.WriteLine($"Число {value} кратно 7 и 23");
else Console.WriteLine($"Число {value} не кратно 7 и 23");



