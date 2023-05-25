Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number <= 999)
{
    Console.WriteLine(number%10);
}
else if (number > 999)
{
    string n = Convert.ToString(number);
    Console.WriteLine(n[2]);
}
else
{
    Console.WriteLine("Введены некоректные данные! Введите трехзначное или более число!");
}
