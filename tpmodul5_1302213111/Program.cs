// See https://aka.ms/new-console-template for more information

public class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine("Halo user " + user.ToString());
    }

    static void Main(string[] args)
    {
        HaloGeneric haloGeneric = new HaloGeneric();
        Console.Write("Masukkan nama : ");
        string nama = Console.ReadLine();
        haloGeneric.SapaUser(nama);
    }
}
