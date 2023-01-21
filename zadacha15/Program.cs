// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является
// ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите номер дня недели: ");
int numbers = Convert.ToInt32(Console.ReadLine());
if (numbers < 8 && numbers > 0)
{
    if (numbers < 6 && numbers > 0)
    {
        Console.WriteLine("нет, не является выходным");
    }

    else
    {
        Console.WriteLine("да, является выходным");
    }
}
else
{
    Console.WriteLine("Такого дня не существует");
}
