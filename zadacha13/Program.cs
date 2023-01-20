// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите лубую цыфру: ");
int numbersA = Convert.ToInt32(Console.ReadLine());
if (numbersA > 99)
{
    while (numbersA >= 1000) numbersA /= 10;
    Console.Write(numbersA % 10);
}
else
{
    Console.Write("нет третий цыфры");    
}
