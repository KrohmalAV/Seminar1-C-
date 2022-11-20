Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
 int i = 0 - a;
 while(i <= a)
 {
    Console.Write($"{i} ");
    i++;
 }