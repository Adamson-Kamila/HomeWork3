﻿// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// int [] array = new int [8];

Console.Clear();

void array()
{
  int [] myArray = new int [8]; //запрос на создание массива, наполненного 8 элементами целочисленными значениями
  for (int i = 0; i < myArray.Length; i++) // условия: счетику for необходимо сделать несколько повторов, 
  // объявляем переменную i, которой присвоаиваем значение "0". Цикл for будет  совершать повтор, не превышающий 
  // длину массива - i < myArray.Length. i++ - этот раздел итератора увеличивает значение счетчика на 1.
  {
      int array = new Random().Next(1, 1001); //пока условия for выполняются, переменной array присваиваются рандомные
      // значения по порядку от 1 до 1000.
      myArray [i] = array; //  массиву myArray присваиваются значения aray.
  }
 Console.Write("[{0}]", string.Join(", ", myArray)); //вывод на экран готового массива.
}

array();
