int a;
int b;
int c;
int max=a;
Console.WriteLine("Введите три числа.");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
с = Convert.ToInt32(Console.ReadLine());
if (b>max)
{
    max=b;
}
if (c>max){max=c}

Console.WriteLine(max);