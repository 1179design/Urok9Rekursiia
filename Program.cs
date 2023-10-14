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


    //     Console.Write("Введите значение M: ");
    //     int M = int.Parse(Console.ReadLine());

    //     Console.Write("Введите значение N: ");
    //     int N = int.Parse(Console.ReadLine());

    //     int sum = SumNaturalNumbers(M, N);

    //     Console.WriteLine($"Сумма натуральных чисел в промежутке от {M} до {N} равна: {sum}");
    

    // static int SumNaturalNumbers(int m, int n)
    // {
    //     if (m > n)
    //     {
    //         return 0; // базовый случай: сумма натуральных чисел в пустом промежутке равна 0
    //     }

    //     return m + SumNaturalNumbers(m + 1, n);
    // }

// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


        Console.Write("Введите значение m: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите значение n: ");
        int n = int.Parse(Console.ReadLine());

        int result = AckermannFunction(m, n);

        Console.WriteLine($"A({m}, {n}) = {result}");
    

    static int AckermannFunction(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return AckermannFunction(m - 1, 1);
        }
        else
        {
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        }
    }
