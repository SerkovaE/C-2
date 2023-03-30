int a;
int b;
Console.WriteLine("Введите два числа.");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
if (a>b)
{
    Console.Write("max=");
    Console.Write(a);
}
else 
{
    Console.Write("max=");
    Console.Write(b);
}
