﻿//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("введите число больше или равное 1");
int numbersA = Convert.ToInt32(Console.ReadLine());
int numbersB = 1;
if(numbersA > 1)
{
    while (numbersB != numbersA)

        if (numbersB % 1 == 0)
        {
            Console.WriteLine(numbersB*numbersB*numbersB);
        numbersB += 1;
        }
}
else
{
    Console.Write("Введенное число меньше 1");
}