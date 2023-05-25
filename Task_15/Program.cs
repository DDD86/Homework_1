Console.WriteLine("Введите число дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 6 || number == 7)
{
    Console.WriteLine("Ура! Сегодня ВыХоДнОй!");
}
else if (number >= 1 && number <=5)
{
    Console.WriteLine("Рабочий день!");
}
else
{
Console.WriteLine("Введите число от 1 до 7!");
}

