// Напишите функцию, которая принимает одно число - высоту елочки и рисует ее в консоли звездочками.

Console.Clear();
Console.WriteLine("Введите высоту ёлки: ");
int height = int.Parse(Console.ReadLine()!);

void three()
{
int x = 2;

 for (int i = 0; i < height; i++) //цикл для перевода курсора на следующую строку
 {
    
   for (int j = height-1; j > i; j-- ) //Перед переводом на следующую строку выполняется цикл для печати пробела
   // расстояние от левого края консоли до ёлки зависит от ее высоты. Это расстояние уменьшается на 1 шаг c  
   // каждым переходом на новую строку.
   {
      Console.Write(" ");  
   }

  for (int k = 1; k < x; k++ ) // После печати строки пробелов, запускаем цикл печати звездочек.
   {
      Console.Write("*");
   }
   x = x + 2; // для требуемого количества (*), цикл for зависит от переменной x.

 Console.WriteLine();
 }
}

three();
