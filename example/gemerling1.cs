using System;

class HelloWorld
{
    static void Main()
    {
        Console.Write("Введiть початкове значення Xmin:");
        string sxMin = Console.ReadLine();
        double xMin = Double.Parse(sxMin);
        Console.Write("Введiть кiнцеве значення Xmax:");
        string sxMax = Console.ReadLine();
        double xMax = double.Parse(sxMax);
        Console.Write("Введiть прирiст dX: ");
        string sdx = Console.ReadLine(); double dx = double.Parse(sdx);
        double x = xMin;
        double y;
        double sum = 0;
        while (x <= xMax)
        {
            y = ((6 - (Math.Cos(3 + x))) / (34 - 9 * (Math.Pow(x, 3) + x)));
            Console.WriteLine("x = {0}\t\t y = {1}", x, y);
            x += dx;
            sum += x;
        }
        if (Math.Abs(x - xMax) / dx < 0.0001)
        {
            y = ((6 - (Math.Cos(3 + x))) / (34 - 9 * (Math.Pow(x, 3) + x)));
            Console.WriteLine("x = {0}\t\t y = {1}", xMax, y);
            sum += x;
        }
        Console.WriteLine("suma = {0}", sum);
        Console.ReadKey();
    }
}