
public class HaloGeneric
{
    public void SapaUser<U>(U user)
    {
        Console.WriteLine($"Halo {user}");
    }
}
class Program
{
    private static void Main(string[] args)
    {
        // Membuat instance dari kelas HaloGeneric
        HaloGeneric halo = new HaloGeneric();

        // Memanggil metode SapaUser dengan menyediakan argumen string "Zidan"
        halo.SapaUser<String>("Zidan");
    }
}
