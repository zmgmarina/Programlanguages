﻿//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int size = Convert.ToInt32(Console.ReadLine()); 
int[] array = new int[size]; 
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(100,1000);
    Console.Write(array[i] + "\t ");
}
 
int count = 0;
for (int i = 0; i < array.Length; i++)
{
  if (array[i] % 2 == 0)
  count++;
}
            
Console.WriteLine($"В данном массиве положительных чисел: {count} ");
