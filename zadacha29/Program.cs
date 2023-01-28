// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]
// int Proverka(int numbersA)
// {
  
//     if(numbersA > 0 && numbersA <= 8)
//     {
           
//     }
//     else
//     {
//     System.Console.WriteLine("Ошибка!!!");
//     System.Console.WriteLine("Введенное число не неходится в диапозоне от 1 до 8");
//     }
            
//     return numbersA;      
// }
// при числе больше 8 выводит ошибку, но все равно делает массив 

int Proverka(int numbersA)
{
            int[] array = new int[numbersA]; 
            for(int i = 0; i < numbersA; i++)
            {
            array[i] = new Random().Next(10);    
            }
            Console.WriteLine($"[{String.Join(", ", array)}]");
                      
    return numbersA;
}

Console.WriteLine("Программа создаст массив длинной от 1 до 8 элементов");
Console.WriteLine("Введите длинну массива меньше или равную 8 элементам");
int numbers = Convert.ToInt32(Console.ReadLine());
if(numbers > 0 && numbers <= 8)
    {
    int array = Proverka(numbers); 
      
    }  
    else
    {    
    System.Console.WriteLine("Ошибка!!!");
    System.Console.WriteLine("Введенное число не неходится в диапозоне от 1 до 8");
    }


    
// Console.WriteLine("Программа создаст массив длинной от 1 до 8 элементов");
// Console.WriteLine("Введите длинну массива меньше или равную 8 элементам");
// int numbers = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[numbers];
//     if(numbers > 0 && numbers <= 8)
//     {
//         for(int i = 0; i < numbers; i++)
//         {
//         array[i] = new Random().Next(10);
//         } 
//         Console.WriteLine($"[{String.Join(", ", array)}]");  
//     }
//     else
//     {
//         System.Console.WriteLine("Ошибка!!!");
//         System.Console.WriteLine("Введенное число не неходится в диапозоне от 1 до 8");
//     }
