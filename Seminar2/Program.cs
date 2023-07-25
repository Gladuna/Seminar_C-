// Семинар 2 - теория

/* Деление нацело (уходит наименьший разряд десятков)

13254 /10 = 1325
13254/100 =132
13254/1000 = 13
13254/100000 = 1
Умножение
13254 %10 =4
13254 %100 = 54
13254 %1000 = 254
13254 %10000 = 3254
Например как извлечь число 43 из 24365 = 24365 / 100 % 100 получится 43
*/
/* Задача 1. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.//
int CutNumber (int num)
{
    int hundreds = num / 100;
    int units = num % 10;
    int res = hundreds * 10 + units;
    return res;
}

int randNumber = new Random().Next(100, 1000);
int newNumber = CutNumber(randNumber);
Console.WriteLine($"New version of {randNumber} is {newNumber}");
*/
/* Задча 2. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b.
bool IsDivisible (int num, int div1, int div2);
{
    if(num % div1 == 0 && num % div2 ==0)
    return true;
    else 
    return false;
} 
//можно еще записать как return num % div1 == 0 && num % div2 ==0 без if и else//
Console.Write("Input a number for checking: ");
int number = Convert.ToInt32 (Console.ReadLine());
Console.Write("Input a first divider: ");
int divider1 = Convert.ToInt32 (Console.ReadLine());
Console.Write("Input a second divider: ");
int divider2 = Convert.ToInt32 (Console.ReadLine());
bool res = IsDivisible(num, div1, div2);
if(res)Console.Write("Yes!");
else Console.Write("No!");
*/
/* Задача 3. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
int Segment (int num)
{int num1 = numb1 / 10;
int num2 = num2 % 10;
if (num1 > num2)
    return num1;
else
    return num2;
}

int number = new Random().Next(10, 100);
Console.WriteLine(number);
int res = (Segment);
Console.WriteLine(num);
*/
