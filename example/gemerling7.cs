using System;

class Photoap {

    public string Designer;
    public string Model;
    public int Release;
    public int Version;
    public int Gen;
    public int CamQual;
    public int Weight;
    public bool HasFlash;

    public string GetName() {
        return Designer + " " + Model;
    }
}

class HelloWord
{
    static void Main()
    {
        Console.Write("Введiть кiлькiсть: ");
        int n = int.Parse(Console.ReadLine());
        Photoap[] PhotoArray = new Photoap[n];

        for (int i = 0; i < n; ++i)
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
            Console.ReadKey();
            Console.Write("\n");
            PhotoArray[i] = Photo;
        }
        Console.Write("\n\n");
        for (int i = 0; i < n; ++i)
        {
            Console.WriteLine("designer: ", PhotoArray[i].Designer);
            Console.WriteLine("model: ", PhotoArray[i].Model);
            Console.WriteLine("release: ", PhotoArray[i].Release);
            Console.WriteLine("version: ", PhotoArray[i].Version);
            Console.WriteLine("gen: ", PhotoArray[i].Gen);
            Console.WriteLine("cam quality (mgpx): ", PhotoArray[i].CamQual);
            Console.WriteLine("weight: ", PhotoArray[i].Weight);
            Console.WriteLine("has flash (y/n): ", PhotoArray[i].HasFlash);
            Console.WriteLine("Full name:", PhotoArray[i].GetName());
            Console.Write("\n\n");
        }
    }
}