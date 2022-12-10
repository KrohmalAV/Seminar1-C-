/*
Задача 42: Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
*/

Console.Clear();
Console.Write("Введите десятичное число: ");
int num = Convert.ToInt32(Console.ReadLine());
string binaryNum = string.Empty;
while(num>0)
{
    binaryNum = Convert.ToString(num%2) + binaryNum;
    num /= 2;
}
Console.Write(binaryNum);