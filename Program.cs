/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
double[,] create_random_2d_array()
{
    Console.Write("Input a quantity rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a quantity columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
   
    double [,] array = new double[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;;
        }
    }
        return array;
}

void show_2d_array (double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }    
        Console.WriteLine();
    }

}

double [,] myArray = create_random_2d_array();
show_2d_array(myArray);
System.Console.WriteLine();
*/

/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] create_random_2d_array()
{
    Console.Write("Input a quantity columns: ");
    int columns= Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a quantity rows: ");
    int  rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int [,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
        return array;
}
void show_2d_array (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }    
        Console.WriteLine();
    }

}

void printarray (int[,] array)
{
    Console.Write("Введите номер строки: ");
        int row = int.Parse(Console.ReadLine());

        Console.Write("Введите номер столбца: ");
        int col = int.Parse(Console.ReadLine());

        int numRows = array.GetLength(0);
        int numCols = array.GetLength(1);

        if (row >= 0 && row < numRows && col >= 0 && col < numCols)
        {
            int element = array[row, col];
            Console.WriteLine($"Значение элемента в позиции ({row}, {col}): {element}");
        }
        else
        {
            Console.WriteLine("Указанные позиции не существуют в массиве.");
        }
    }

int [,] myArray = create_random_2d_array();
show_2d_array(myArray);
printarray(myArray);
*/


/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int[,] create_random_2d_array()
{
    Console.Write("Input a quantity columns: ");
    int columns= Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a quantity rows: ");
    int  rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int [,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
        return array;
}
void show_2d_array (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }    
        Console.WriteLine();
    }

}
void arithmeticMean (int[,] array)

{int numRows = array.GetLength(0);
int numCols = array.GetLength(1);
double [] columnAverages = new double[numCols];

for (int col = 0; col < numCols; col++)
        {
            double columnSum = 0;

            for (int row = 0; row < numRows; row++)
            {
                columnSum += array[row, col];
            }

            columnAverages[col] = columnSum / numRows;
        }

        // Вывод средних арифметических для каждого столбца
        Console.WriteLine("Средние арифметические для каждого столбца:");
        for (int col = 0; col < numCols; col++)
        {
            Console.WriteLine($"Столбец {col + 1}: {columnAverages[col]}");
        }
    }

int [,] myArray = create_random_2d_array();
show_2d_array(myArray);
arithmeticMean (myArray);
*/















