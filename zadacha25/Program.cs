﻿// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Ste(int numbers, int numbersC)

{
    int ste = numbers;
    int numbersB = numbersC;
    for(int i = 1; i < numbersB; i++)
    {
        numbers = numbers*ste; 
    }
    return numbers;
}

int InputNumbers(string str)
{
    int numbers;
    string text;
    while(true)
    {
        Console.WriteLine(str);
        text = Console.ReadLine();
        if(int.TryParse(text, out numbers))
        {
            break;
        }
        Console.WriteLine("Ошибка!!! Введено не верное значение!");
    }
    return numbers;
}

//Console.WriteLine("введите число А: ");
int A = InputNumbers("Введите число A: ");
//Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("введите число B: ");
int B = InputNumbers("Введите число В: ");
//Convert.ToInt32(Console.ReadLine());
int steA = Ste(A, B);
Console.WriteLine($"{A} в степени {B} = {steA}");