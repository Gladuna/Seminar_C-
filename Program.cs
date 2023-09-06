// Рекурсия//

/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение N: ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("N должно быть натуральным числом.");
            return;
        }

        Console.WriteLine("Натуральные числа от N до 1:");

        // Вызываем рекурсивную функцию
        PrintNaturalNumbers(n);

        Console.ReadLine();
    }

    static void PrintNaturalNumbers(int n)
    {
        // Базовый случай: если n стало равным 0, завершаем рекурсию
        if (n == 0)
            return;

        // Выводим текущее значение n и вызываем функцию для n-1
        Console.WriteLine(n);

        // Рекурсивный вызов для числа n-1
        PrintNaturalNumbers(n - 1);
    }
}
*/

/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите два неотрицательных целых числа m и n:");
        Console.Write("m: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());

        int result = AckermannFunction(m, n);
        Console.WriteLine($"Результат функции Аккермана для ({m}, {n}) = {result}");

        Console.ReadLine();
    }

    static int AckermannFunction(int m, int n)
    {
        if (m == 0)
            return n + 1;
        else if (n == 0)
            return AckermannFunction(m - 1, 1);
        else
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }
}
*/

/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение M: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int n = int.Parse(Console.ReadLine());

        if (m <= 0 || n <= 0)
        {
            Console.WriteLine("M и N должны быть натуральными числами.");
        }
        else if (m > n)
        {
            Console.WriteLine("M должно быть меньше или равно N.");
        }
        else
        {
            int sum = SumNaturalNumbers(m, n);
            Console.WriteLine($"Сумма натуральных чисел от {m} до {n} = {sum}");
        }

        Console.ReadLine();
    }

    static int SumNaturalNumbers(int m, int n)
    {
        if (m == n)
            return m;
        else
            return m + SumNaturalNumbers(m + 1, n);
    }
}

*/




