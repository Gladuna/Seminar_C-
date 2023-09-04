/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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
void sorts_array(int [,] array)
{
    int numRows = array.GetLength(0);
    int numCols = array.GetLength(1);
    for (int row = 0; row < numRows; row++)
        {
           
            for (int i = 0; i < numCols - 1; i++)
            {
                for (int j = i + 1; j < numCols; j++)
                {
                    if (array[row, i] < array[row, j])
                    {
            
                        int temp = array[row, i];
                        array[row, i] = array[row, j];
                        array[row, j] = temp;
                    }
                }
            }
        }
        Console.WriteLine("Упорядоченный массив по убыванию:");
        for (int row = 0; row < numRows; row++)
        {
            for (int col = 0; col < numCols; col++)
            {
                Console.Write(array[row, col] + " ");
            }
            Console.WriteLine();
}
}
int [,] myArray = create_random_2d_array();
show_2d_array(myArray);
sorts_array(myArray);
*/

/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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

void min_array(int[,] array)
    {
        int numRows = array.GetLength(0);
        int numCols = array.GetLength(1);

        int minRowSum = int.MaxValue; // Начальное значение для сравнения

        int minRowIndex = -1; // Индекс строки с наименьшей суммой

        // Находим строку с наименьшей суммой элементов
        for (int row = 0; row < numRows; row++)
        {
            int rowSum = 0;

            for (int col = 0; col < numCols; col++)
            {
                rowSum += array[row, col];
            }

            if (rowSum < minRowSum)
            {
                minRowSum = rowSum;
                minRowIndex = row;
            }
        }

        // Выводим результат
        Console.WriteLine($"Строка с наименьшей суммой элементов: {minRowIndex}");
    }
int [,] myArray = create_random_2d_array();
show_2d_array(myArray);
min_array(myArray);
*/

/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
    
using System;

class Program
{
    static void Main(string[] args)
    {
        // Задаем первую матрицу (3x2)
        int[,] matrix1 = {
            { 1, 2 },
            { 3, 4 },
            { 5, 6 }
        };

        // Задаем вторую матрицу (2x3)
        int[,] matrix2 = {
            { 7, 8, 9 },
            { 10, 11, 12 }
        };

        // Проверяем, можно ли умножить матрицы
        int numRows1 = matrix1.GetLength(0);
        int numCols1 = matrix1.GetLength(1);
        int numRows2 = matrix2.GetLength(0);
        int numCols2 = matrix2.GetLength(1);

        if (numCols1 != numRows2)
        {
            Console.WriteLine("Умножение матриц невозможно, так как количество столбцов первой матрицы не соответствует количеству строк второй матрицы.");
            return;
        }

        // Создаем результирующую матрицу (3x3)
        int[,] resultMatrix = new int[numRows1, numCols2];

        // Вычисляем произведение матриц
        for (int i = 0; i < numRows1; i++)
        {
            for (int j = 0; j < numCols2; j++)
            {
                resultMatrix[i, j] = 0;
                for (int k = 0; k < numCols1; k++)
                {
                    resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        // Выводим результат
        Console.WriteLine("Результат умножения матриц:");
        for (int i = 0; i < numRows1; i++)
        {
            for (int j = 0; j < numCols2; j++)
            {
                Console.Write(resultMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
*/

/*Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
using System;

class Program
{
    static void Main(string[] args)
    {
        int[,,] threeDimensionalArray = new int[4, 3, 2];
        int startValue = 10;

        // Заполняем трехмерный массив неповторяющимися двузначными числами
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    threeDimensionalArray[i, j, k] = startValue++;
                }
            }
        }

        // Выводим трехмерный массив построчно с индексами
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    Console.WriteLine($"Элемент [{i},{j},{k}] = {threeDimensionalArray[i, j, k]}");
                }
            }
        }
    }
}

*/

/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
using System;

class Program
{
    static void Main(string[] args)
    {
        int n = 4; // Размерность массива (4x4)
        int[,] spiralArray = new int[n, n];

        int value = 1; // Значение, которое будет записано в ячейки массива

        int rowStart = 0;
        int rowEnd = n - 1;
        int colStart = 0;
        int colEnd = n - 1;

        while (value <= n * n)
        {
            // Движение вправо
            for (int col = colStart; col <= colEnd; col++)
            {
                spiralArray[rowStart, col] = value;
                value++;
            }
            rowStart++;

            // Движение вниз
            for (int row = rowStart; row <= rowEnd; row++)
            {
                spiralArray[row, colEnd] = value;
                value++;
            }
            colEnd--;

            // Движение влево
            for (int col = colEnd; col >= colStart; col--)
            {
                spiralArray[rowEnd, col] = value;
                value++;
            }
            rowEnd--;

            // Движение вверх
            for (int row = rowEnd; row >= rowStart; row--)
            {
                spiralArray[row, colStart] = value;
                value++;
            }
            colStart++;
        }

        // Выводим заполненный массив
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write(spiralArray[row, col] + "\t");
            }
            Console.WriteLine();
        }
    }
}
*/





