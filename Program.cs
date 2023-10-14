// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


    
    //     Console.Write("Введите значение N: ");
    //     int N = int.Parse(Console.ReadLine());

    //     Console.WriteLine("Результат: " + PrintNumbers(N));
    

    // static string PrintNumbers(int n)
    // {
    //     if (n == 1)
    //     {
    //         return "1";
    //     }

    //     return n + ", " + PrintNumbers(n - 1);
    // }

    
// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


        Console.Write("Введите значение M: ");
        int M = int.Parse(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int N = int.Parse(Console.ReadLine());

        int sum = SumNaturalNumbers(M, N);

        Console.WriteLine($"Сумма натуральных чисел в промежутке от {M} до {N} равна: {sum}");
    

    static int SumNaturalNumbers(int m, int n)
    {
        if (m > n)
        {
            return 0; // базовый случай: сумма натуральных чисел в пустом промежутке равна 0
        }

        return m + SumNaturalNumbers(m + 1, n);
    }

