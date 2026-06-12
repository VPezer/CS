using System;

class Zadatak1
{
    static void Main()
    {
        try
        {
            Console.Write("Unesite prvi broj: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Unesite drugi broj: ");
            int b = int.Parse(Console.ReadLine());

            // Dijelimo kao double da dobijemo decimalni rezultat
            double rezultat = (double)a / b;

            Console.WriteLine("\nRezultati dijeljenja {0} / {1}:", a, b);
            Console.WriteLine("Currency    (C): {0:C}", rezultat);
            Console.WriteLine("Integer     (D): {0:D}", a / b);       // samo cijeli dio
            Console.WriteLine("Scientific  (E): {0:E}", rezultat);
            Console.WriteLine("Fixed-point (F): {0:F}", rezultat);
            Console.WriteLine("General     (G): {0:G}", rezultat);
            Console.WriteLine("Number      (N): {0:N}", rezultat);
            Console.WriteLine("Hexadecimal (X): {0:X}", a / b);       // samo cijeli dio
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Greška: Dijeljenje s nulom nije dopušteno.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Greška: Unesite cijeli broj.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Greška: Broj je prevelik za tip int.");
        }
    }
}