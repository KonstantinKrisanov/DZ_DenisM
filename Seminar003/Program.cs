// Нахождение двух максимумов
// Console.Clear();
// int n = Convert.ToInt32(Console.ReadLine());
// int max_f = n;
// int max_s = -1;
// while (n != 0)
// {
// n = Convert.ToInt32(Console.ReadLine());
// if (n > max_f)
// {
// max_s = max_f;
// max_f = n;
// }
// else if (n > max_s)
// {
// max_s = n;
// }
// }
// Console.WriteLine(max_s);


//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// void InputXY()
// {
// Console.Write("Input x");
// double x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input y");
// double y = Convert.ToInt32(Console.ReadLine());
// if (x > 0 && y > 0)
// Console.Write("Первая четверть");
// else if (x > 0 && y < 0)
// Console.Write("Вторая четверть");
// else if (x < 0 && y < 0)
// Console.Write("Третья четверть");
// else if (x < 0 && y > 0)
// Console.Write("Четвертая четверть");
// }
// InputXY();


//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
// Console.Clear();
// int n = Convert.ToInt32(Console.ReadLine());
// while (n < 1 || n > 4)
// n = Convert.ToInt32(Console.ReadLine());

// if (n == 1)
// Console.WriteLine("x > 0 and y > 0");
// if (n == 2)
// Console.WriteLine("x < 0 and y > 0");
// if (n == 3)
// Console.WriteLine("x < 0 and y < 0");
// if (n == 4)
// Console.WriteLine("x > 0 and y < 0");

//Напишите программу которая принемает на вход координаты двух точек и находит растояние между ними в 2D Пространстве.
// Console.Clear();
// Console.WriteLine("Введите координаты двух точек");
// Console.Write("Введите x1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите x2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// double L = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
// Console.WriteLine("Расстояние между точками равно: " + L);

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// Console.Clear();
// int n = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= n; i++)
// Console.WriteLine(i + "^2 = " + i * i);



// DZ

//  Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
void Polindrom()
{
 Console.Write("Введите пятизначное число");
 double n = Convert.ToInt32(Console.ReadLine());
if (Convert.ToString(n)[0] == Convert.ToString(n)[4] && Convert.ToString(n)[1] == Convert.ToString(n)[3])
    Console.WriteLine("Полиндром");
else
    Console.WriteLine("Не полиндром");
}
 Polindrom();