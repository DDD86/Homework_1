﻿Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
    Console.WriteLine((number/10)%10);
}
else
{
    Console.WriteLine("Введены некоректные данные!");
}
