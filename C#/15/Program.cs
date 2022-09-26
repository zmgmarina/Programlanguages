// Напишите прогр., которая принимает на вход число (N)
// и  выдает таблицу квадратов чисел от 1 до N/
// 5 -> 1,4,9,16,25.
// 2 -> 1,4.
// for (точка старта, условие,увеличение счетчика)

// int start = 1; //точка старта
// int end = 5; 

// while (start <= end)
// {
//     Console.WriteLine(start*start);
//     start++;
// }


//а теперь через цикл for (точка старта, условие выхола из цикла, увеличение счетчика)
int end = Convert.ToInt32(Console.ReadLine());

for(int start = 1; start <= end; start++)
{
    Console.WriteLine(start*start);
}