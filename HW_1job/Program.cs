﻿                                                                // Задача 2: 
//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее. 
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
                                                                //РЕШЕНИЕ:
// Console.WriteLine("Введите первое число");
// int numa = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int numb = Convert.ToInt32(Console.ReadLine());

// if(numa > numb) {
//     Console.WriteLine($"Max = {numa}");
//     Console.WriteLine($"Min = {numb}");
// }
// else
// {
//     Console.WriteLine($"Max = {numb}");
//     Console.WriteLine($"Min = {numa}");
// }


//---------------------------------------------------------------------------------------------------------------------------------------------------

                                                                // Задача 4: 
//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

                                                                //РЕШЕНИЕ:

// int Max = 0;
// Console.WriteLine("Введите первое число");
// int numa = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int numb = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число");
// int numc = Convert.ToInt32(Console.ReadLine());


// if (numb > Max) Max = numb;
// if(numc > Max) Max = numc;

// Console.WriteLine($"{Max} - Максимальное число");



                                                    // Задача 6: 
// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

                                                    // Решение:

// Console.WriteLine("Введите число");
// int a = Convert.ToInt32(Console.ReadLine());
// if (a % 2 == 0)
// {
//     Console.WriteLine("Четное число");
// }
// else
// {
//     Console.WriteLine("Не Четное число");
// }


                                                    // Задача 8: 
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = num;
Console.WriteLine($"{num} = ");

for(int i = 0; i < num; i++) {
    if(result % 2==0)
    {
        Console.Write($"{result}, ");
    }
    result--;
} 



