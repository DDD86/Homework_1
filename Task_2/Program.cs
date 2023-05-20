Console.Write("Введите первое число: ");
int first_number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int second_number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int third_number = Convert.ToInt32(Console.ReadLine());
if (first_number > second_number && first_number > third_number){
    Console.WriteLine($"{first_number} больше, чем {second_number} и {third_number}");
}
else if(second_number > first_number && second_number > third_number){
    Console.WriteLine($"{second_number} больше, чем {first_number} и {third_number}");
}
else{
    Console.WriteLine($"{third_number} больше, чем {first_number} и {second_number}"); 
}
