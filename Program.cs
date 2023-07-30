//Task #1
/*
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

//Task #2
/*
void PowerPrinter(int n) {
    for(int i = 1; i <= n; ++i) {
       Console.WriteLine(i + " - " + Math.Pow(i, 2));
    }
}

int n;

Console.Write("Please enter a number to powering: ");
n = Convert.ToInt32(Console.ReadLine());

PowerPrinter(n);
*/

//Task 3
/*
double DecartDistanceFinder(double x1, double y1, double x2, double y2) 
{
    return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
}

double x1;
double y1;
double x2;
double y2;

Console.Write("Please enter x1: ");
x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Please enter y1: ");
y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Please enter x2: ");
x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Please enter y2: ");
y2 = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("The distance between points is {0:f2}", DecartDistanceFinder(x1, y1, x2, y2));

*/