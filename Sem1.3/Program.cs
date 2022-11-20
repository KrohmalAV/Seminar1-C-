Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
 int i = 0 - a;
 if(a >= 0)
 {
   while(i <= a)
   {
      Console.Write($"{i} ");
      i++;
   }
 }
 else
 {
   while(i >= a)
   {
      Console.Write($"{i} ");
      i--;
   }
 }