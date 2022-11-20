Console.WriteLine("Введите номер дня недели: ");
int a = Convert.ToInt32(Console.ReadLine());

if(a == 1)
{Console.WriteLine($"{a} - понедельник");}
else if(a == 2)
{Console.WriteLine($"{a} - вторник");}
else if(a == 3)
{Console.WriteLine($"{a} - среда");}
else if(a == 4)
{Console.WriteLine($"{a} - четверг");}
else if(a == 5)
{Console.WriteLine($"{a} - пятница");}
else if(a == 6)
{Console.WriteLine($"{a} - суббота");}
else if(a == 7)
{Console.WriteLine($"{a} - воскресение");}
else
{Console.WriteLine("такого дня недели не существует");}