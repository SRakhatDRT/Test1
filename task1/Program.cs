﻿/*
Задайте значения M и N. Напишите
программу, которая выведет все натуральные числа
в промежутке от M до N. Использовать рекурсию, не
использовать циклы.

M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8"
*/

Console.Write("Введите значение M: "); 
int M = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите значение N: "); 
int N = Convert.ToInt32(Console.ReadLine()); 

void PrintNaturalNumbers(int current, int N) 
    { 
        if (current <= N) 
        { 
            Console.Write(current + " "); 
            PrintNaturalNumbers(current + 1, N);
        } 
    } 
PrintNaturalNumbers(M, N); 