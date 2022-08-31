Console.WriteLine("Input first number ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input sekond number ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
   int Max = a;
   Console.Write("Max =  ");
   Console.WriteLine(Max);
   int Min = b;
   Console.Write("Min =  ");
   Console.WriteLine(Min);
}
   else
   {
    int Max = b;
    Console.Write("Max =  ");
    Console.WriteLine(Max);
     int Min = a;
     Console.Write("Min =  ");
   Console.WriteLine(Min);
   }