using System;

class Zadatak2
{
    static void Main()
    {
        long velikiBroj = long.MaxValue;
        int maliBroj;

        Console.WriteLine("long.MaxValue = {0}", velikiBroj);

        try
        {
            // checked blok provjerava overflow pri pretvorbi
            maliBroj = checked((int)velikiBroj);
            Console.WriteLine("Pretvorba uspješna: {0}", maliBroj);
        }
        catch (OverflowException)
        {
            Console.WriteLine("Greška: Vrijednost {0} ne stane u int.", velikiBroj);
            Console.WriteLine("int.MaxValue = {0}", int.MaxValue);
        }
    }
}