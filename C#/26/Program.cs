// 40. напишите прогу, которая принимает на вход три числа и проверяет, может ли 
// существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треуг. меньше суммы двух других сторон.
// Т.е.  а=3 в=4 с=5
// а+в > c
// a+c > b
// b+c > a

int a = 3;

int b = 4;

int c = 5;

//bool - True / False
bool IsTriangle(int a, int b, int c) // на вход подаем стороны
{
    return ((a + b > c) && (a + c > b) && (b + c > a)); // все условия должны быть True
}
Console.WriteLine(IsTriangle(a,b,c));


