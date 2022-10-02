// переворачиваем массив методом пузырька:


int[] array = GetArray(10, 0, 10); // size = 10, диапазон элементов: [0;10]
Console.WriteLine(String.Join(" ", array));

int[] reversArray = CopyArray(array);
Console.WriteLine(String.Join(" ", reversArray)); // С копией массива, оригинал не изменяется

ReverseArray(array);
Console.WriteLine(String.Join(" ", array));
// Меняете исходный массив, но дополнительный массив не создается

int[] GetArray(int size, int minValue, int maxValue)
{
int[] res = new int[size];

for (int i = 0; i < size; i++)
{
    res[i] = new Random().Next(minValue, maxValue + 1);
}
return res;
}

void ReverseArray(int[] inArray)
{
for (int i = 0; i < inArray.Length / 2; i++)
{
int temp = inArray[i];
inArray[i] = inArray[inArray.Length - i - 1];
inArray[inArray.Length - i - 1] = temp;
}
}

int[] CopyArray(int[] inArray)
{
int[] result = new int[inArray.Length];
for (int i = 0; i < inArray.Length; i++) // inArray.Length = size
{
result[i] = inArray[inArray.Length - 1 - i]; // size - 1
}
return result;
}