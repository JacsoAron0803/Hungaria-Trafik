using Hungaria_Trafik.Model;
using System.Runtime.CompilerServices;

internal class Program
{
    private static List<List<string>> adatok = new List<List<string>>();
    private static List<Termekek> termekek = new List<Termekek>();
    private static FileIO.ReadFromFile reader = new FileIO.ReadFromFile();
    private static void Main(string[] args)
    {
        Adatbeolvasas("termekek.csv", 6, ';', true);
        AdatBetoltes(adatok);
        Console.WriteLine("Hány éves vagy?");
        int felh_kor = Convert.ToInt32(Console.ReadLine());
        if (felh_kor >= 18)
        {
            Console.WriteLine("Miben segíthetek?\n1--Termék lekérdezés\n2--Összes termék kilistázása" +
                "\n3--Vásárlás");
            int valasz = Convert.ToInt32(Console.ReadLine());
            if (valasz == 1)
            {
                TermekLekerdezes(termekek);
            }
            else if (valasz == 2) 
            {
                OsszesTListazasa(termekek);
            }
            else if (valasz== 3) 
            {
                Vasarlas(termekek);
            }
        }
        else
        {
            Console.WriteLine("Térj vissza, ha nagykorú vagy!");
            System.Threading.Thread.Sleep(3000);
            return;
            

        }

    }

    private static void Vasarlas(List<Termekek> termekek)
    {
        throw new NotImplementedException();
    }

    private static void OsszesTListazasa(List<Termekek> termekek)
    {
        

    }


    private static void TermekLekerdezes(List<Termekek> termekek)
    {
        throw new NotImplementedException();
    }
    private static void AdatBetoltes(List<List<string>> adatok)
    {
        foreach (var item in adatok)
        {
            Termekek a = new Termekek(Convert.ToInt32(item[0]), item[1], item[2], Convert.ToInt32(item[3]), Convert.ToInt32(item[4]), Convert.ToInt32(item[5]));
            termekek.Add(a);
        }
    }

    private static void Adatbeolvasas(string v1, int v2, char v3, bool v4)
    {
        adatok = reader.FileRead(v1,v2,v3,v4);
    }
}