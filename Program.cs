/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int DegreeNumbers(int numberA, int numberB)
{
  int result = 1;
  for(int i=1; i <= numberB; i++)
  {
    result = result * numberA;
  }
    return result;
}

  Console.Write("Введите число A: ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите степень числа - число В: ");
  int numberB = Convert.ToInt32(Console.ReadLine());

  int degreenumbers = DegreeNumbers(numberA, numberB);
  Console.WriteLine($"Число A в натуральной степени B = " + degreenumbers);
*/

/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int SumNumber (int num)
   {
    int counter = Convert.ToString(num).Length;
    int advance = 0;
    int result = 0;
    for (int i = 0; i < counter; i++)
    {advance = num - num % 10;
    result = result + (num - advance);
    num = num / 10;}
    return result;
}

int randNumber = new Random().Next(1, 10000);
int newNumber = SumNumber(randNumber);
Console.WriteLine($"Сумма цифр в {randNumber} - {newNumber}");
*/

// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

/*
        int[] CreateArray(int size, int minValue, int maxValue, int eleme)
        {
            int[] array = new int[size];
      
            for (int i = 0; i < size; i++)
            
            array[i] = Convert.ToInt32(Console.ReadLine()); 
            return array;
        }
        void WriteArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
            Console.WriteLine();
        }
        Console.Write("Введите длину массива: ");
        int lenght = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите минимальный элемент массива: ");
        int min = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите максимальный элемент массива: ");
        int max = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите 1-й элемент массива: "); 
        int eleme = Convert.ToInt32(Console.ReadLine());
        int[] myArray = CreateArray(lenght, min, max, eleme);
        WriteArray(myArray);
    
*/