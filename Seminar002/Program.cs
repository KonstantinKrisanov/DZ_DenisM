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

int GenerateRandomNumbers()
{
    int n = new Random().Next(10, 100);   // генерирует случайное число в заданном диапозоне
    return n;
}
void ComprasisNumbers()
{
    int n = GenerateRandomNumbers();
    Console.WriteLine(n);
    int a = n / 10;                       // а это первая цыфра числа , а b втораяю
    int b = n % 10;
    if (a > b)
        Console.WriteLine(a);
     else if (a < b)
         Console.WriteLine(b);
     else
          Console.WriteLine("=");        
}
ComprasisNumbers();