// 39. напишите прогу, которая перевернет одномерный массив 
// [12345] -> [54321]
// [6736] -> [6376]

int size = Convert.ToInt32(Console.ReadLine()); //размер массива
int[] array = new int[size]; // создаем массив
//заполняем массив
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(11);
    Console.Write(array[i] + "\t ");
}

// 1 способ: "Перевернутая" копия массива

Console.WriteLine();

Console.WriteLine("Перевернутый массив: ");
int[] reverseArray = new int[size]; 
int lastIndex = size - 1; //размер с 1, индексы с 0.  lastIndex последний элемент массива
for (int i = 0; i < size; i++)
{
    reverseArray[i] = array[lastIndex - i];
    Console.Write(reverseArray[i] + "\t ");
}





