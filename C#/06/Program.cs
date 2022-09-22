// 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12 -> 2
// 85 -> 8

int number = Convert.ToInt32(Console.ReadLine());

int firstDigit = number / 10;  // 78->7

int secondDigit = number % 10; // 78->8

int maximum = firstDigit;      // Пусть макс.- первое число

if (secondDigit > maximum)  maximum = secondDigit;

Console.WriteLine("Наибольшая цифра в числе" + number + " - это " + maximum); //Конкатенация: "1" + "2" = "12"

//Интерполяция   Console.WRiteLine($ "Текст: {переменная} ")
Console.WriteLine($"Наибольшая цифра в числе {number} - это {maximum}");