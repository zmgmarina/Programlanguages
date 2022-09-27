// 24. Напишите программу, которая на вход принимает число (А) и выдает сумму чисел от 1 до А
// 7-> 28
// 4-> 10
// 8-> 36
// [1;A]
// int A = Convert.ToInt32(Console.ReadLine());
// int sum = 0;   //для хранения сумм вводим переменную, изначально переменная пустая

// Aлгоритм: A = 4
// sum = sum + i
// i = 1, sum = 0, A = 4
// 1. sum = 0 + 1, sum = 1, i++ (i=2)
// 2. sum = 1 + 2, sum = 3, i++ (i=3)
// 3. sum = 3 + 3, sum = 6, i++ (i=4)
// 4. sum = 6 + 4, sum = 10,i++ (i<=4)

// for (int i = 1; i <= A; i++)
// {
//     sum += i;  //sum = sum + i
// }
// Console.WriteLine($"Сумма чисел от 1 до {A} = {sum}");

// Вариант задачи с использованием метода
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNumbers(number));

int SumNumbers (int end) // Это метод. в качестве параметра мы передаем сюда одно число в виде переменной "end"
// end - это число А/ это локальная переменная внутри метода
{
    int sum = 0;
    for (int i = 1; i <= end; i++)
    {
        sum +=i;
    }
    return sum; // ретерном возвращаем значение sum
}


