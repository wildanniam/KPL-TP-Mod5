// See https://aka.ms/new-console-template for more information

public class HaloGeneric
{
    public static void SapaUser<T>(T sapa)
    {
        Console.WriteLine("Halo User " + sapa);
    }
}
class DataGeneric<T>
{
    T data;
    public DataGeneric(T data)
    {
        this.data = data;
    }
    public void PrintData()
    {
        Console.WriteLine("Data yang disimpan adalah: " + data);

    }
}

class Program
    {
        public static void Main(string[] args)
        {
            HaloGeneric.SapaUser<String>("Wildan");
            var data = new DataGeneric<String>("1302220005");
            data.PrintData();
        }
    }
        
    
