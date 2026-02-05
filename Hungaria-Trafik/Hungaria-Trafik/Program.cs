using Hungaria_Trafik.Model;

internal class Program
{
    private static List<List<string>> adatok = new List<List<string>>();
    private static List<Termekek> termekek = new List<Termekek>();
    private static FileIO.ReadFromFile reader = new FileIO.ReadFromFile();
    private static void Main(string[] args)
    {
        Adatbeolvasas("termekek.xlsx", 6, ';', true);
        AdatBetoltes(adatok);
        EletkorEllenor();
    }

    private static void AdatBetoltes(List<List<string>> adatok)
    {
        foreach (var item in adatok)
        {
            Termekek a = new Termekek(Convert.ToInt32(item[0]), item[1], item[2], Convert.ToInt32(item[3]), Convert.ToInt32(item[4]), Convert.ToInt32(item[5]));
        }
    }

    private static void Adatbeolvasas(string v1, int v2, char v3, bool v4)
    {
        adatok = reader.FileRead(v1,v2,v3,v4);
    }
}