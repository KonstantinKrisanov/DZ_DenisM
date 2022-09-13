// Задача на плюсовую температуру
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];

// for (int i = 0; i < array.Length; i++)
// array[i] = Convert.ToInt32(Console.ReadLine());

// int count = 0;
// int count_max = 0;
// for (int i = 0; i < array.Length; i++)
// {
// if (array[i] > 0)
// count++;

// if (array[i] < 0)
// count = 0;

// if (count_max < count)
// count_max = count;
// }
// Console.WriteLine(count_max);


//Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// Console.WriteLine("Input number ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write(((a + 1) / 2 ) * a);

// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// Console.WriteLine("Input number ");
// int a = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// while (a >= 10)
// {
//     a = a / 10;
//     count++;
// }
// Console.Write(count);
 

 //Напишите программу, которая принимает на вход число N и выдаёт произведение чисел
//  Console.WriteLine("Input number ");
//  int a = Convert.ToInt32(Console.ReadLine());
//  int i = 1;
//  int proizv = 1;
//  while (i <= a )
//  {
//       proizv = proizv * i;
//       i++;
//  }
//  Console.Write(proizv);

// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// int[] array = new int[8];

// for (int i = 0; i < array.Length; i++)
// array[i] = new Random().Next(0, 2);  // первое число включается в диапозон , а последнее нет

// Console.WriteLine("[" + string.Join(", ", array) + "]"); // Красивый вывод массива


// DZ

//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Console.WriteLine("input first number");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input sekond number");
// int b = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// int dop = 1;
// while (b >= count)
// {
//     dop = dop * a;
//     count++;
// }
// Console.WriteLine(dop);


//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Console.WriteLine("input number");
// int a = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// if (a > 9)
// {
//     while (a > 0)
//     {
//         sum += a % 10;
//         a /= 10;
//     }
//     Console.WriteLine(sum);
// }
// else
//   Console.WriteLine("enter a two-digit number");


//  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] array = new int[8];
Console.WriteLine("Enter 8 array numbers");
int i = 0;
while (i < array.Length)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
    i++;
}
Console.WriteLine("[" + string.Join(", ", array) + "]");
