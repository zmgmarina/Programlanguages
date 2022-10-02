// Задача 32: Напишите программу замена элементов массива: положительные элементы замените 
// на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int size = 4;
int[] array = new int[size];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10,11);
    Console.Write(array[i] + "\t");   
    array[i] = array[i] * (-1);
}   

Console.WriteLine();
Console.WriteLine($"{String.Join(", ", array)}" );

//второй вариант:
//int[] array = { -2,-1,0,1,2};  // если вводим значения с консоли ставим фигурные скобки



