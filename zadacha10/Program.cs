﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Random rand = new Random();
int randN = rand.Next(100, 1000);
Console.WriteLine("исходное число: " + randN);
Console.WriteLine(randN/10 % 10);

