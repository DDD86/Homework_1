﻿Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number%2 == 0){
    Console.WriteLine($"Ваше число {number} является четным");
}
else{
    Console.WriteLine($"Ваше число {number} является нечетным");
}
