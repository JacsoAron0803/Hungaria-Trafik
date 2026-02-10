using System.IO;
using Hungaria_Trafik.Model;
using System.Runtime.CompilerServices;

internal class Program
{
    private static List<List<string>> adatok = new List<List<string>>();
    private static List<Termekek> termekek = new List<Termekek>();
    private static FileIO.ReadFromFile reader = new FileIO.ReadFromFile();
    private static FileIO.WriteToFile writer = new FileIO.WriteToFile();
    public static int kilistazottValasz;
    public static string valasztottTermek;
    public static string vasarolniKivantTermek;
    public static int szorzott;
    private static void Main(string[] args)
    {
        Adatbeolvasas("termekek.csv", 6, ';', true);
        AdatBetoltes(adatok);

        Console.WriteLine(@" ██╗  ██╗██╗   ██╗███╗   ██╗ ██████╗  █████╗ ██████╗ ██╗ █████╗   ████████╗██████╗  █████╗ ███████╗██╗██╗  ██╗");
        Console.WriteLine(@" ██║  ██║██║   ██║████╗  ██║██╔════╝ ██╔══██╗██╔══██╗██║██╔══██╗  ╚══██╔══╝██╔══██╗██╔══██╗██╔════╝██║██║ ██╔╝");
        Console.WriteLine(@" ███████║██║   ██║██╔██╗ ██║██║  ███╗███████║██████╔╝██║███████║     ██║   ██████╔╝███████║█████╗  ██║█████╔╝ ");
        Console.WriteLine(@" ██╔══██║██║   ██║██║╚██╗██║██║   ██║██╔══██║██╔══██╗██║██╔══██║     ██║   ██╔══██╗██╔══██║██╔══╝  ██║██╔═██╗ ");
        Console.WriteLine(@" ██║  ██║╚██████╔╝██║ ╚████║╚██████╔╝██║  ██║██║  ██║██║██║  ██║     ██║   ██║  ██║██║  ██║██║     ██║██║  ██╗");
        Console.WriteLine(@" ╚═╝  ╚═╝ ╚═════╝ ╚═╝  ╚═══╝ ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚═╝╚═╝  ╚═╝     ╚═╝   ╚═╝  ╚═╝╚═╝  ╚═╝╚═╝     ╚═╝╚═╝  ╚═╝");
        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
        Console.WriteLine();
        System.Threading.Thread.Sleep(2000);
        Console.WriteLine("Szia! Hány éves vagy?");
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
                Console.WriteLine("Milyen termék fajtát szeretnél?\n 1--Cigaretta\n2--Hevített dohány" +
                    "\n3--Készülék\n4--E-cigaretta\n5--Kiegészítő\n6--Dohány\n7--Szivar" +
                    "\n8--Egyéb");
                 kilistazottValasz = Convert.ToInt32(Console.ReadLine());
                OsszesTListazasa(termekek);



            }
            else if (valasz== 3) 
            {
                Console.WriteLine("Melyik terméket szeretnéd megvásárolni? (pontosan add meg a nevet)");
                vasarolniKivantTermek = Console.ReadLine();
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
        int db = 0;
        bool van = false;

        foreach (var item in termekek)
        {
            if (item.Name1.ToLower().Contains(vasarolniKivantTermek.ToLower()))
            {
                Console.WriteLine("Hány darabot szeretnél vásárolni?");
                db = Convert.ToInt32(Console.ReadLine());
                szorzott = db * Convert.ToInt32(item.Price1);
                Console.WriteLine($"Összesen {szorzott}Ft lesz!");
                van = true;
                string sor = $"{item.Name1}; {db} db; {szorzott} Ft\n";
                File.AppendAllText("vasarlok.txt", sor);
                Console.WriteLine("Vásárlás sikeres!");
                Console.WriteLine("Viszlát, további szép napot!");
                System.Threading.Thread.Sleep(3000);
                return;


            }
            else if (!van)
            {
                Console.WriteLine("Nincs ilyen termék!");
            }
        }
    }

    private static void OsszesTListazasa(List<Termekek> termekek)
    {
        if(kilistazottValasz == 1) 
        {
            foreach (var item in termekek)
            {
                if (item.Category1.Contains("Cigaretta"))
                {
                    Console.WriteLine($"Név : {item.Name1} Ár: {item.Price1} Raktáron: {item.Stock1}");
                }
            }
        }
        else if (kilistazottValasz == 2) 
        {
            foreach (var item in termekek)
            {
                if (item.Category1.Contains("Hevitett dohany"))
                {
                    Console.WriteLine($"Név : {item.Name1} Ár: {item.Price1} Raktáron: {item.Stock1}");
                }

            }
        }
        else if (kilistazottValasz == 3)
        {
            foreach (var item in termekek)
            {
                if (item.Category1.Contains("Keszulek"))
                {
                    Console.WriteLine($"Név : {item.Name1} Ár: {item.Price1} Raktáron: {item.Stock1}");
                }
            }
        }
        else if (kilistazottValasz == 4)
        {
            foreach (var item in termekek)
            {
                if (item.Category1.Contains("E-cigaretta"))
                {
                    Console.WriteLine($"Név : {item.Name1} Ár: {item.Price1} Raktáron: {item.Stock1}");
                }
            }
        }
        else if (kilistazottValasz == 5)
        {
            foreach (var item in termekek)
            {
                if (item.Category1.Contains("Kiegeszito"))
                {
                    Console.WriteLine($"Név : {item.Name1} Ár: {item.Price1} Raktáron: {item.Stock1}");
                }
            }
        }
        else if (kilistazottValasz == 6)
        {
            foreach (var item in termekek)
            {
                if (item.Category1.Contains("Dohany"))
                {
                    Console.WriteLine($"Név : {item.Name1} Ár: {item.Price1} Raktáron: {item.Stock1}");
                }
            }
        }
        else if (kilistazottValasz == 7)
        {
            foreach (var item in termekek)
            {
                if (item.Category1.Contains("Szivar"))
                {
                    Console.WriteLine($"Név : {item.Name1} Ár: {item.Price1} Raktáron: {item.Stock1}");
                }
            }
        }
        else if (kilistazottValasz == 8)
        {
            foreach (var item in termekek)
            {
                if (item.Category1.Contains("Egyeb"))
                {
                    Console.WriteLine($"Név : {item.Name1} Ár: {item.Price1} Raktáron: {item.Stock1}");
                }
            }
        }
        

    }


    private static void TermekLekerdezes(List<Termekek> termekek)
    {     
        Console.WriteLine("Melyik termékről szeretnéd megtudni, hogy van e készleten?");
        valasztottTermek = Console.ReadLine();
        bool van = false;
        string vasarolniAkar;
        foreach (var item in termekek) 
        { 
            if (item.Name1.ToLower().Contains(valasztottTermek.ToLower()))
            {
                Console.WriteLine($"{item.Name1} nevű termékből {item.Stock1} van raktáron!");
                van = true;
                Console.WriteLine("Szeretnél vásárolni valamit? (igen/nem)");
                vasarolniAkar = Console.ReadLine();
                if (vasarolniAkar == "igen")
                {
                    Console.WriteLine("Melyik terméket szeretnéd megvásárolni? (pontosan add meg a nevet)");
                    vasarolniKivantTermek = Console.ReadLine();
                    Vasarlas(termekek);
                }
                else
                {
                    Console.WriteLine("Viszlát, további szép napot!");
                    System.Threading.Thread.Sleep(3000);
                    return;
                }
                break;
            }
            else if (!van)
            {
                Console.WriteLine("Ilyen nevű dohányterméket nem árulunk!");
            }
        }

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