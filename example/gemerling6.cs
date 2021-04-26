using System;

class Photoap
{

    public string Designer;
    public string Model;
    public int Release;
    public int Version;
    public int Gen;
    public int CamQual;
    public int Weight;
    public bool HasFlash;

    public string GetName()
    {
        return Designer + " " + Model;
    }
}

class HelloWorld
{
    static void Main()
    {
        Photoap Photo = new Photoap();
        Console.Write("designer: ");
        Photo.Designer = Console.ReadLine();
        Console.Write("model: ");
        Photo.Model = Console.ReadLine();
        Console.Write("release: ");
        Photo.Release = int.Parse(Console.ReadLine());
        Console.Write("version: ");
        Photo.Version = int.Parse(Console.ReadLine());
        Console.Write("gen: ");
        Photo.Gen = int.Parse(Console.ReadLine());
        Console.Write("camera quality (mgpx): ");
        Photo.CamQual = int.Parse(Console.ReadLine());
        Console.Write("weight: ");
        Photo.Weight = int.Parse(Console.ReadLine());
        Console.Write("has Flash: ");
        ConsoleKeyInfo keyFlash = Console.ReadKey();
        Photo.HasFlash = keyFlash.Key == ConsoleKey.Y ? true : false;
        Console.Write("\nFull name: {0}", Photo.GetName());
        Console.ReadKey();
    }
}