using System;
class HelloWorld
{
    const double StartX = 10.3; const double dX = 0.7;

    static double Function(double x)
    {
        return (Math.Pow(Math.Sin(x),3)+45+x)/(2*Math.Pow(x,4)+4*x);
    }

    static void Main()
    {
        double[] arr = new double[10];

        double x = StartX;
        for (int i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0); i++)
        {
            arr[i] = Function(x); x += dX;
        }

        Array.Sort(arr);
        Array.Reverse(arr);

        Console.WriteLine("Вiдсортованi за спаданням значення масиву: ");

        for (int i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0); i++)
        {
            Console.WriteLine("arr[{0:00}] = {1:0.0000}", i, arr[i]);
        }
        double aMin = arr[arr.GetUpperBound(0)]; double aMax = arr[arr.GetLowerBound(0)];

        double aAvg = 0;
        for (int i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0); i++)
        {
            aAvg += arr[i];
        }
        aAvg = aAvg / arr.GetLength(0);
        int R = 0;
        for (int i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0); i++)
        {
            if (arr[i] < (aMin + Math.Abs(aMin) * 0.1))
            {
                R += 0;
            }
        }

        Console.WriteLine("Мiнiмальне значення масиву: {0:0.0000}", aMin);
        Console.WriteLine("Максимальне значення масиву: {0:0.0000}", aMax);
        Console.WriteLine("Середнє значення масиву: {0:0.0000}", aAvg);
        Console.WriteLine("R: {0}", R);
        Console.ReadKey(true);
    }
}
