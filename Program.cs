

/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int [] CreateRandomArray (int size)
{
    int [] array = new int[size];
    for (int i = 1; i < size; i++)
        {
            Console.Write($"Введите число: {i}: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
    return array;
}

void WriteArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write (array [i] + " ");
    Console.WriteLine();
}

int ZeroNumbers (int [] array)
{   int sum = 0;
    for(int i = 0; i < array.Length; i++)
    if (array [i] > 0)
    sum = sum + 1;
    return sum; 
}
Console.Write ("Введите количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateRandomArray (m);
WriteArray(myArray);
Console.WriteLine ($"количество чисел больше нуля " + " " + ZeroNumbers(myArray));
*/

/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.WriteLine("Введите переменную b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите переменную k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите переменную b2: «");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("Введите переменную k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;

Console.Write($"\n Точка пересечения двух прямых: [{x},{y}]");
*/