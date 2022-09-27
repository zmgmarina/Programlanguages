// Напишите прогр, которая принимает на вход число и выдает кол-во цифр в числе 
// 456-> 3
// 78-> 2
// 89126 -> 5

// Простой вариант
// Console.WriteLine("Введите число: ");
// string number = Console.ReadLine();

// Console.WriteLine(number.Length);


// Второй вариант:
Console.Write("Введите число: ");          // Вводим число и сохраняем его в переменную number 
int number = Convert.ToInt32(Console.ReadLine());     // используя метод (Console.ReadLine()) чтобы получить строчку
// введенную строчку конвертируем  в формат Convert.ToInt32

// Алгоритм:
// 456 -> 3
// 456/10 = 45(1)
// 45/10 = 4(2)
// 4/10 = (3)
// 0/0=0
// Пока частное не равен нулю.

int GetCountNumbers (int num) //переменная может называться как угодно
{
    int count = 0;
    while (num > 0)
    {
        count++;
        num /= 10;  // знак равно значит что мы результат сохраняем в эту переменную num.
    }
    return count; // кол-во цифр в числе
}
Console.WriteLine(GetCountNumbers(number));


