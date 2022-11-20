Console.Clear();
Console.Write("Введите номер дня недели (от 1 до 7): ");
int a = Convert.ToInt32(Console.ReadLine());
if(a == 1)
{
    Console.WriteLine($"{a} день недели - понедельник");
}
else if(a == 2)
{
    Console.WriteLine($"{a} день недели - вторник");
}
else if(a == 3)
{
    Console.WriteLine($"{a} день недели - среда");
}
else if(a == 4)
{
    Console.WriteLine($"{a} день недели - четверг");
}
else if(a == 5)
{
    Console.WriteLine($"{a} день недели - пятница");
}
else if(a == 6)
{
    Console.WriteLine($"{a} день недели - суббота");
}
else if(a == 7)
{
    Console.WriteLine($"{a} день недели - воскресение");
}
else
{
    Console.WriteLine("Такого дня недели не существует. Необходимо было ввести число от 1 до 7...");
}