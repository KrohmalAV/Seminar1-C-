int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int b2 = b * b;
if(a == b2)
{
    Console.WriteLine($"{a} является квадратом {b}");
}
else
{
    Console.WriteLine("{a} не является квадратом {b}");
}