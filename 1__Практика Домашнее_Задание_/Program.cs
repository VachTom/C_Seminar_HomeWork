                    /*







                    Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
                    какое число большее, а какое меньшее.

                    a = 5; b = 7 -> max = 7
                    a = 2 b = 10 -> max = 10
                    a = -9 b = -3 -> max = -3



    Console.Write("Введите ПЕРВОЕ число: ");
    int NumberA = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите ВТОРОЕ число: ");
    int NumberB = Convert.ToInt32(Console.ReadLine());
    
    if (NumberA > NumberB) Console.Write($"Максимальное значение: {NumberA}");
    else Console.Write($"Максимальное значение: {NumberB}");









                Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

            2, 3, 7 -> 7
            44 5 78 -> 78
            22 3 9 -> 22

          




    Console.Write("Введите ПЕРВОЕ число: ");
    int NumberA = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите ВТОРОЕ число: ");
    int NumberB = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите ТРЕТЬЕ число: ");
    int NumberC = Convert.ToInt32(Console.ReadLine());
    
    if (NumberA > NumberB)
    {
        if (NumberA > NumberC) Console.Write($"Максимальное значение: {NumberA}");
        else if (NumberC > NumberA) Console.Write($"Максимальное значение: {NumberC}");
    }
    else if (NumberB > NumberC) Console.Write($"Максимальное значение: {NumberB}");
    else if (NumberC > NumberB) Console.Write($"Максимальное значение: {NumberC}");
    
  

 


  Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет





Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());


if ((Number % 2) != 0) Console.Write("Это число не четное!");
else Console.Write("Это число ЧЕТНОЕ!");




// Можно было решить задачу через оператор Math.DivRem(Number,2);







Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/



Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());


while (Number >= 1)
{
   if (Number % 2 == 0) 
   {
        Console.Write(Number + " ");
        Number = Number - 1;
    }

   else 
   {
        Number = Number - 1;
    }
}

Console.WriteLine("");

