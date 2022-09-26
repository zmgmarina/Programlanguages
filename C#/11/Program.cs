// Это я поигралась)
//Console.WriteLine("Какая сегодня температура?");
//int temp = Convert.ToInt32(Console.ReadLine());

//if (temp < 0) Console.WriteLine("Нужно надеть шапку");
//else Console.WriteLine("Смотрим по погоде");

int temp = -30;
//else if =  в Pyton называется elif
// если используем несколько условий (if), являющихся истиной, оператор elif начинает проверку, находит первую истину
// и досрочно возвращает результат, не продолжая проверку.
// Т.е. if возвращает несколько истин. значений, а elif только одно. Это своего рода оптимизация кода.
if (temp < 0) Console.WriteLine("Нужно надеть шапку");
else if (temp < -20) Console.WriteLine("Сидим дома");
else if (temp < -25) Console.WriteLine("Идем гулять");