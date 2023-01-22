// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Write("введите пятизначное число: ");
int numbers = Convert.ToInt32(Console.ReadLine());
string text = Convert.ToString(numbers);
if(numbers > 9999 && numbers < 100000)
{
    if(text[0] == text[4] && text[1] == text[3])
    {
        Console.Write("является палиндромом");
    }
    else
    {
    Console.Write("не является палиндромом");   
    }
}
else
{
    Console.Write("введенное число не является пятизначным");
}