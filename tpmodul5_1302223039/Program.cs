
public class HaloGeneric
{
    public void SapaUser<U>(U user)
    {
        Console.WriteLine($"Halo {user}");
    }
}

public class DataGeneric<T>
{
    private T Data;
    public DataGeneric(T data)
    {
        Data = data;
    }
    public void PrintData()
    {
        Console.WriteLine($"Data yang tersimpan adalah: {Data}");
    }
}
class Program
{
    private static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser<String>("Zidan");

        DataGeneric<string> dataGeneric = new DataGeneric<string>("1302223039");
        dataGeneric.PrintData();
    }
}