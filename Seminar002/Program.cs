// Отличие void 
// void f(ref int n) //Когда мы передаем процедуру без ref мы передаем копию этой переменной, а что бы обратиться к основной переменной нужно указывать ref.
// {
//     n += 5;
// } 
// int n = 5;
// f(ref n);
// Console.Write(n);   // т.е. с реф результат будет 10, а без 5.

// int f(int n)
// {
//     return n * 2;    // return возвращает какое то значение и завершает в этом же месте работу функции
// }
// int n = 10;
// Console.Write(f(n));

// ЗАДАЧИ С СЕМИНАРА

// int GenerateRandomNumbers()
// {
//     int n = new Random().Next(10, 100);   // генерирует случайное число в заданном диапозоне
//     return n;
// }
// void ComprasisNumbers()
// {
//     int n = GenerateRandomNumbers();
//     Console.WriteLine(n);
//     int a = n / 10;                       // а это первая цыфра числа , а b втораяю
//     int b = n % 10;
//     if (a > b)
//         Console.WriteLine(a);
//      else if (a < b)
//          Console.WriteLine(b);
//      else
//           Console.WriteLine("=");        
// }
// ComprasisNumbers();


// int GenerateRandomNumbers()
// {
//     int n = new Random().Next(100, 1000);   // генерирует случайное число в заданном диапозоне
//     return n;
// }
// void ComprasisNumbers()
// {
//     int n = GenerateRandomNumbers();
//     Console.WriteLine(n);
//     int a = n / 100;                       // а это первая цыфра числа , а b втораяю
//     int b = n % 10;
//     Console.WriteLine(a * 10 + b);
// }
// ComprasisNumbers();

// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деление.

// void InputNambers()
// {
// Console.WriteLine("Input first number ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input sekond number ");
// int b = Convert.ToInt32(Console.ReadLine());
// if (b % a == 0) 
//   Console.WriteLine("b Kratno a");
//   else
//    Console.WriteLine("Ostatok ot deleniya " + b % a);
// }
// InputNambers();


// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.


// void InputNamber()
// {
// Console.WriteLine("Input number ");
// int a = Convert.ToInt32(Console.ReadLine());
// if (a % 7 ==0 && a % 23 ==0)
//  Console.WriteLine("Chislo kratno 7 i 23");
//  else 
//  Console.WriteLine("Chislo ne kratno 7 i 23");
// }
// InputNamber();

//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// void InputNambers()
// {
// Console.WriteLine("Input first number ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input sekond number ");
// int b = Convert.ToInt32(Console.ReadLine());
//   if (a * a == b || b * b == a)
//     Console.WriteLine("Yes");
//     else 
//     Console.WriteLine("No");
// }
// InputNambers();

//   DZ


// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// void InputNumber()
// {
//     Console.WriteLine("Input number ");
// int n = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine(n);
//     int a = n / 100;                       
//     int b = n % 10;
//     Console.WriteLine(n % 100 / 10);
// }
// InputNumber();

//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//  int GenerateRandomNumbers()
// {
//     int n = new Random().Next(0, 1000);   // генерирует случайное число в заданном диапозоне
//     return n;
// }
// void OutputOfTheThirdNumber()
// {
//     int n = GenerateRandomNumbers();
//     Console.WriteLine(n);
//     if (n < 100)
//        Console.WriteLine("No third digit");
//     else 
//         Console.WriteLine(Convert.ToString(n)[2]);
// }
// OutputOfTheThirdNumber();


//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void weekends()
{
    Console.Write("Input nomber 1 - 7 ");
int n = Convert.ToInt32(Console.ReadLine());

    if (n > 5)
        Console.WriteLine("weekends");
    else
        Console.WriteLine("Work ");
    while (n < 1 || n > 7)
        Console.Write("error");
}
weekends();