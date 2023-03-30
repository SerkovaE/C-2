int numberA;
int numberB;
int numberC;
Console.WriteLine("Введите три числа.");
numberA = Convert.ToInt32(Console.ReadLine());
numberB = Convert.ToInt32(Console.ReadLine());
numberC = Convert.ToInt32(Console.ReadLine());
int max=numberA;
if (numberB>max)
{
    max=numberB;
}
if (numberC>max)
{
    max=numberC;
}

Console.Write("max=");
Console.Write(max);