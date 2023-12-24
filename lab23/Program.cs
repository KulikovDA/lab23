Console.Write("Введите А:");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите В:");
int B = int.Parse(Console.ReadLine());
if ((A > 0 && B < 0) || (A < 0 && B > 0))
{
    A = -A;
    B = -B;
}
else
{
    A = 0;
    B = 0;
}

Console.WriteLine("A = " + A);
Console.WriteLine("B = " + B);