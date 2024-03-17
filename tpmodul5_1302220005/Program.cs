// See https://aka.ms/new-console-template for more information
public class HaloGeneric
{
    public static void SapaUser<T>(T sapa)    
    {
        Console.WriteLine("Halo User " + sapa);
    }
}

class Program
{
    static void Main(string[] args)
    {
        HaloGeneric.SapaUser<String>("Wildan");
    }
}
