Console.Write("Введите первое число: ");
int first_number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int second_number = Convert.ToInt32(Console.ReadLine());
if (first_number > second_number){
    Console.WriteLine($"{first_number} больше, чем {second_number}");
}
else{
    Console.WriteLine($"{second_number} больше, чем {first_number}");
}
