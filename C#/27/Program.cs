// 44. Не используя рекурсию выведите перые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 7 -> 0 1 1 2 3 5 8

// 1 способ - через массив

// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];

// arr[0] = 0;
// arr[1] = 1;

// for (int i = 2; i < n; i++)  // т.к. 0 1 заполнен, идем от 2
// {
//     arr[i] = arr[i-1] + arr[i-2]; // arr[i-1] - предыдущее число; arr[i-2] - предпредыдущее число 

// }
// System.Console.WriteLine(String.Join(", ", arr));


// 2 вариант - через числа

int number = 10; // Кол-во чисел Фибоначчи
if (number < 2) return;                          // если int number будет равно 1, программа сломается, цикл не будет работать 
int firstnumber = 0; // первое число              //поэтому используем проверку if и пустой return
int secondtnumber = 1; //второе число
Console.Write(firstnumber + "\t");
Console.Write(secondtnumber + "\t");

for (int i = 3; i < number; i++)
{
    int nextnumber = firstnumber + secondtnumber;
    Console.Write(nextnumber + "\t");
    firstnumber = secondtnumber;                    //next = first + second
    secondtnumber = nextnumber;                     // Пусть мы ищем next = 5, значит first=2, second=3
}                                                   // next(5) = first(2) + second(3) **
                                                    // Чтобы найти число 8 (next):
                                                    // next(8) = first(3) + second(5)*
                                                    // Из (**) получаем: first = second
                                                    //                   second = next