// Seminar3//
/* Theory
Math.Pow ()-принимает 2 значения, первое это основание степени, второе это степень.
Math.Sqrt () - принимает одно значение и находит квадратный корень числа.
Math.Round() - округляет вещественное число, принимает два аргумента. Первое само число которое надо округлить, второе число до какой степени нужно округлить, уровень округления.


/* Task1. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
void WriteRange (int quadrant)
{
    if(quadrant < 1 || quadrant > 4) F
    else if (quadrant ==1) Console.WriteLine ("x > 0 and y > 0");
    else if (quadrant ==2) Console.WriteLine ("x < 0 and y > 0");
    else if (quadrant ==3) Console.WriteLine ("x < 0 and y < 0");
    else Console.WriteLine ("x < 0 and y > 0");
}
Console.Write("Input a number of quadrant: ");
int quard = Convert.ToInt32 (Console.ReadLine());

WriteRange (quard);
*/

/*Task2. Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
int QuarterFinder(int x, int y) {
    if (x == 0 || y == 0 ) {
        Console.WriteLine("It's not possible to set zero coordinates");
    }
    if (x > 0 && y > 0) {
        return 1;
    } else if (x < 0 && y > 0) {
        return 2;
    } else if (x < 0 && y < 0) {
        return 3;
    } else {
        return 4;
    }
}

int x;
int y;

Console.Write("Please enter coordinate x: ");
x = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter coordinate y: ");
y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("The quarter is " + quarterFinder(x, y));
*/

/* Task3. Напишите программу, которая принимает на вход число (N) и выдаёт квадраты чисел от 1 до N.
void WriteQuad(int number)
{
int current = 1;
while (current <= number)
 {
 Console.WriteLine($"{current} - {current * current}");
current++;
 }
}
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
WriteQuad (number);
*/

/*Task4. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

double Distance(double x1, double y1, double x2, double y2)
{
 double deltaX = x2 - x1;
 double deltaY = y2 - y1;
 return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
}
Console.Write("Input x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(Distance (x1, y1, x2, y2));
*/

//Домашнее задание_семинар_3
/* Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите число: ");
string? number = Console.ReadLine();

void CheckingNumber(string number)
{
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine($"Ваше число: {number} - палиндром.");
  }
  else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
}

if (number!.Length >= 1)
{
  CheckingNumber(number);
}
else Console.WriteLine($"Введи правильное число");
*/

/* Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double Distance3D (double x1, double y1, double x2, double y2, double z1, double z2)
{
 return Math.Round (Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)));
}

Console.Write("Please, input x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Please, input y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Please, input z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Please, input x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Please, input y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Please, input z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());
double distance = Distance3D (x1, y1, z1, x2, y2, z2);
Console.WriteLine("The distance between points is {0:f2}", distance);
*/


/* Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void WriteCub (int number)
{
int current = 1;
while (current <= number)
 {
 Console.WriteLine($"{current} - {current * current * current}");
current++;
 }
}
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
WriteCub (number);
*/