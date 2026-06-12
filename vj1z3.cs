using System;

// Pobrojani tip za vrstu računa
enum VrstaRacuna
{
    Stednja,
    TekuciRacun,
    ZiroRacun
}

// Struktura koja opisuje jedan bankovni račun
struct BankAccount
{
    public string BrojRacuna;
    public double Iznos;
    public VrstaRacuna Vrsta;
}

class Zadatak3
{
    static void Main()
    {
        BankAccount[] racuni = new BankAccount[5];
        int brojUpisanih = 0;

        while (true)
        {
            Console.WriteLine("\n--- IZBORNIK ---");
            Console.WriteLine("1. Upis novog računa");
            Console.WriteLine("2. Ispis svih računa");
            Console.WriteLine("0. Izlaz");
            Console.Write("Odabir: ");

            string odabir = Console.ReadLine();

            if (odabir == "1")
            {
                if (brojUpisanih >= 5)
                {
                    Console.WriteLine("Polje je puno (max 5 računa).");
                    continue;
                }

                BankAccount novi = new BankAccount();

                Console.Write("Broj računa: ");
                novi.BrojRacuna = Console.ReadLine();

                Console.Write("Iznos: ");
                novi.Iznos = double.Parse(Console.ReadLine());

                Console.WriteLine("Vrsta računa: 0=Štednja, 1=Tekući, 2=Žiro");
                Console.Write("Odabir: ");
                novi.Vrsta = (VrstaRacuna)int.Parse(Console.ReadLine());

                racuni[brojUpisanih] = novi;
                brojUpisanih++;

                Console.WriteLine("Račun uspješno upisan.");
            }
            else if (odabir == "2")
            {
                if (brojUpisanih == 0)
                {
                    Console.WriteLine("Nema upisanih računa.");
                    continue;
                }

                Console.WriteLine("\n--- SVI RAČUNI ---");
                foreach (BankAccount r in racuni)
                {
                    // foreach prolazi kroz svih 5 mjesta, preskačemo prazna
                    if (r.BrojRacuna == null) continue;

                    Console.WriteLine("Broj: {0} | Iznos: {1:F2} | Vrsta: {2}",
                        r.BrojRacuna, r.Iznos, r.Vrsta);
                }
            }
            else if (odabir == "0")
            {
                Console.WriteLine("Doviđenja!");
                break;
            }
            else
            {
                Console.WriteLine("Nepoznat odabir.");
            }
        }
    }
}