﻿// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве

// 4; массив [6,7,19,345,3] -> нет
// 3; массив [6,7,19,345,3] -> да

Console.Write("Введите число: "); // пользователь вводит какое-то число
int num = Convert.ToInt32(Console.ReadLine());

bool b =false; // создаем булевую переменную, по умолчанию равна "ложь"

int[] array = new int[8]; // задаем массив

for (int i = 0; i < array.Length; i++)
{
  
  array[i] = new Random().Next(0,100); // заполняем массив случайными числами
  
  if (num==array[i]) // если хотя бы один раз, то число которое ввел пользователь, равняется тому числу, которое у насесть в массиве
  {
    b=true; // тогда булевая переменная меняется на "истина"
  }
  
}

if (b == true) // если наша переменная поменялась на "истина", следовательно у нас это число точно было
{
  Console.WriteLine("Yes");
}

else // если же оно у нас не поменялось
{
  Console.WriteLine("No");
}

Console.Write(String.Join(", ", array));