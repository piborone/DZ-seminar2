﻿// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Ste(int numbers)

{
    int ste = numbers;
    Console.WriteLine("введите число В: ");
    int numbersB = Convert.ToInt32(Console.ReadLine());
    for(int i = 1; i < numbersB; i++)
    {
        numbers = numbers*ste; 
    }
    return numbers;
}

Console.WriteLine("введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
int steA = Ste(A);
Console.WriteLine($"А в степени В = {steA}");

