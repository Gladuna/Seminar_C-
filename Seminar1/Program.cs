// Seminar 1
 /*int intNumber = 25;
 double doubleNumber = 12.12;
 string text  = "some text";
 bool logicVar = true;

Console.Write ("Input a number: ");
int num = Convert.ToUInt32 (Console.ReadLine());

*/
/* Task 1/ Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
Console.Write ("Input a first number: ");
int num1 = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Input a second number: ");
int num2 = Convert.ToInt32 (Console.ReadLine());

int quard2 = num2 * num2;

if (num1 == quard2)
{
    Console.WriteLine ("Yes"!);
}
else
{
    Console.WriteLine ("No!");
}
*/
/* Task 2/ Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N
Console.Write ("Input a number: ");
int num  = Convert.ToInt32 (Console.ReadLine ());

int current = -num;
while (current <= num)
{
    Console.Write(current + " ");
    current ++;
}
*/
// Домашнее задание семинар 1.//
/* Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int max = 0;
int min = 0;
if(num1 > num2)
{
    max = num1;
    min = num2;
}
else
{
    max = num2;
    min = num1;
}
Console.WriteLine("max = " + max + " , " + "min = " + min);
*/
/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a three number: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = 0;
if(num1 > max)
{
    max = num1;
}
if(num2 > max)
{
    max = num2;
}
if(num3 > max)
{
    max = num3;
}

Console.WriteLine("max = " + max);
*/
/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("Input a first number: ");
int num = Convert.ToInt32(Console.ReadLine());
int remDiv = num % 2;

if(remDiv == 0)
{
    Console.WriteLine("YES!");
}
else
{
    Console.WriteLine("NO!");
}
*/
/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
Console.Write("Input a first number: ");
int num = Convert.ToInt32(Console.ReadLine());
int evenNumber = 2;

if(num > 1)
{
    while(evenNumber <= num)
    {
        Console.Write(evenNumber + " ");
        evenNumber = evenNumber + 2;
    }
}
*/