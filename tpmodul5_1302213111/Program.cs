 
﻿// See https://aka.ms/new-console-template for more information

public class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine("Halo user " + user.ToString());
    }
}
﻿
public class DataGeneric<T>
{
    private T Data { get; set; }

    public DataGeneric(T data)
    {
        Data = data;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + Data);
    }
}

public class Program
{
    static void Main(string[] args)
    {
        HaloGeneric haloGeneric = new HaloGeneric();
        Console.Write("Masukkan nama : ");
        string nama = Console.ReadLine();
        haloGeneric.SapaUser(nama);

        Console.Write("Masukkan NIM : ");
        string nim = Console.ReadLine();
        DataGeneric<string> data = new DataGeneric<string>(nim);
        data.PrintData();
    }
}

