// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] array = { 6, 7, 19, 345, 3 };
int searchNumber = 6; // Число за рамками нашего массива, которое мы ищем
bool flagResult = false; // false - элемент не найден, true - найден
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == searchNumber)
    {
        flagResult = true; // элемент найден
        break;
    }
}
// (flagResult == true) == if(flagResult)
if (flagResult) Console.WriteLine($"Элемент {searchNumber} присутствует");
else Console.WriteLine($"Элемент {searchNumber} отсутствует");
