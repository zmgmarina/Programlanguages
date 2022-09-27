// Напишите прогу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] GetBinaryArray (int size)   //int[] - массив . size - кол-во элементов
{
    int[] array = new int[size]; //new int - это создание нового массива  //если size=5, создается массив из 5 элементов
    for (int i = 0; i < array.Length; i++)  // array.Length = size
    {
        array[i] = new Random().Next(0,2);  //вторая граница диапазона берется на шаг больше/ можно указать только вторую цифру (2) 
    }
    return array;
}

int[] resultArray = GetBinaryArray(8);

Console.WriteLine($"Result array: [ {String.Join(", ", resultArray)} ]"); //Join склеивает элементы массива в одну строчку

//конвертируем массив в строчку 
