/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int CutNumber (int num)
{
    int hundreds = num / 100;
    int units = num % 100;
    return units/10;
}

int randNumber = new Random().Next(100, 1000);
int newNumber = CutNumber(randNumber);
Console.WriteLine($"New version of {randNumber} is {newNumber}");
*/
/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа ( или -1, если третьей цифры нет).
int CutNumber (int num)
{
    int hundreds = num / 100;
    int units = num % 10;
    return units;
}

Console.Write("Input a number: ");
int num1 = Convert.ToInt32 (Console.ReadLine());
int newNumber = CutNumber(num1);
if (num1 < 100)
Console.WriteLine(-1);
else
Console.WriteLine(newNumber);
*/
/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write ("Input a number: ");
int num = Convert.ToInt32 (Console.ReadLine());
bool DaysMumber (int num)
{
    if(num >=1 && num <6)
    return true;
    else 
    return false;
}
bool res = DaysMumber (num);
if(res)Console.Write("Рабочий день!");

bool DaysMumber1 (int num)
{
    if(num >=6 && num <= 7)
    return true;
    else 
    return false;
}
bool res1 = DaysMumber1 (num);
if(res1)Console.Write("Выходной день!");
*/

    