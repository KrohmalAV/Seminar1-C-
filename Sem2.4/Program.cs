/*
Напишите программу, которая принимает на вход число и проверяет,
кратно ли оно одновременно 
7 и 23.
14 -> нет 
46 -> нет 
161 -> да
*/

Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if((a % 7 == 0) && (a % 23 == 0))
{
    Console.WriteLine($"{a} кратно");
}
else 
{
    Console.WriteLine($"{a} не кратно");
}