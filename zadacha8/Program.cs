int N;
int i=2;
Console.WriteLine("Введите число.");
N = Convert.ToInt32(Console.ReadLine());
while (i<=N)
{
    Console.Write(i);
    Console.Write(", ");
    i=i+2;
}

