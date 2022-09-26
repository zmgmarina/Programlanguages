// Метод, который что-то возвращает (return), может быть только один.
// int Calculate(int a, int b)
// {
//     int result = a + b;
//     return result;
// }
// Console.WriteLine(Calculate(3,5));

// можно так: (цифры вводим с консоля)
// Console.WriteLine("Введите первое число: ");
// int firstnumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int secondnumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Результат: ");
// Console.WriteLine(Calculate(firstnumber,secondnumber));



// void VoidCalculate(int a, int b)
// {
//     int result = a + b;               
//         return result;
// }
// // такой код работать не будет
//переменную можем вывести с помощью Сonsole.WriteLine 

// void VoidCalculate(int a, int b)
// {
//     int result = a + b;               
//     Console.WriteLine(result);
//     Console.WriteLine("hello world");
// }
// VoidCalculate(2,3);

int [] arrayTest = {1,2,3,4,5};              // return ничего не возвращает
int[] Calculate(int []array)
{
    return arrayTest;
}
Console.WriteLine($"Результат: {Calculate(arrayTest)}");

void PrintArray (int [] array)               // как можно напечатать массив
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ "");
    }
}
PrintArray(arrayTest);
