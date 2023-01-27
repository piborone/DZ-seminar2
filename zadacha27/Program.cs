//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int Sum(int numbers)

{

string? text = Convert.ToString(numbers);
int numbersA = Convert.ToInt32(Convert.ToString(text!.Length));
int sum = 0;
    for(int i = 0; i < numbersA; i++)
    {
      sum = sum + Convert.ToInt32(Convert.ToString(text[i]));
    }
    return sum;
}

// Console.Write("введите число: ");
// string? text = Console.ReadLine();
// int numbers = Convert.ToInt32(Convert.ToString(text!.Length));
// int sum = 0;
// for(int i = 0; i < numbers; i++)
// {
//    sum = sum + Convert.ToInt32(Convert.ToString(text[i]));
// }
// Console.WriteLine(sum);



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
int A = InputNumbers("Введите число А");
int sum = Sum(A);
Console.WriteLine($"сумма всех чисел цифры {A} = {sum}");

