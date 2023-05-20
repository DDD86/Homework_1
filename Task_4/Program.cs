Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;
if (number < 2){
            Console.WriteLine("Введите число больше 1!");
         }
else{while (i <= number){    // Цикл работает до number включительно
   if (i%2 == 0){
         Console.WriteLine(i);
    }
      
          i++;
}}

