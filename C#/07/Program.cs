// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. 
// 456 -> 46 782 -> 72 918 -> 98
int number = new Random().Next(100, 1000); 

int firstDigit = number / 100;
int thirDigit = number % 10;

Console.WriteLine($"Первая и третья цифра числа {number} - это {firstDigit*10 + thirDigit}");