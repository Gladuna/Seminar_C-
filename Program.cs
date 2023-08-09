/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
int [] CreateRandomArray (int size)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
        array [i] = new Random ().Next(100, 1000);
   return array;
}
void WriteArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write (array [i] + " ");
    Console.WriteLine();
}

int EvenNumbers (int [] array)
{   int sum = 0;
    for(int i = 0; i < array.Length; i++)
    if (array [i] % 2 == 0)
        sum = sum + 1;
    return sum;  
}
Console.Write ("Введите длину массива: ");
int lenght = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateRandomArray (lenght);
WriteArray(myArray);
Console.WriteLine ($"количество четных чисел в масиве" + " - " + EvenNumbers(myArray));
*/

/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int [] CreateRandomArray (int size, int minValue, int maxValue)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
        array [i] = new Random ().Next(minValue, maxValue +1);
   return array;
}
void WriteArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write (array [i] + " ");
    Console.WriteLine();
}
int SumOdd(int [] array)
{
    int result = 0;
    for(int i = 0; i < array.Length; i++)
    if(i % 2 != 0)
    result = result + array [i];
    return result;
}
Console.Write ("Введите длину массива: ");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите минимальный элемент массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите максимальный элемент массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateRandomArray (lenght, min, max);
WriteArray(myArray);
Console.Write ($"сумма элементов на нечётных позициях массива" + " равна " + SumOdd(myArray));
*/

/*Задача 38 (мой вариант): Задайте массив целых чисел. 
//Найдите разницу между максимальным и минимальным элементов массива. Это задача с целым типом данных

int [] CreateRandomArray (int size, int minValue, int maxValue)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
        array [i] = new Random ().Next(minValue, maxValue +1);
   return array;
}

void WriteArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write (array [i] + " ");
    Console.WriteLine();
}
int DifferenceNumders (int[] array)
{
    int min = array [0];
    int max = array [0];
    for(int i = 0; i < array.Length; i++)
        if (array [i] < min)
            min = array [i];
        else if (array [i] > max)
            max = array [i];
    return max - min;
}
Console.Write ("Введите длину массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите минимальный элемент массива: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите максимальный элемент массива: ");
int b = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateRandomArray (m, a, b);
WriteArray(myArray);
Console.Write ($"разницу между максимальным и минимальным элементов массива" + " равна " + DifferenceNumders(myArray));
*/

