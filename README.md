# CS
Practicing C#
Za prvu vjezbu:
Kreirati konzolnu aplikaciju (Solution + Project) — HelloWorld primjer
Koristiti ispravne tipove varijabli i razumjeti razliku između cjelobrojnog i decimalnog dijeljenja
Pisati čitljiv kod s komentarima
Koristiti direktive using i namespace
Pisati jednostavne izraze, kontrolu toka (if, switch) i petlje (for, foreach)

Vjezba 1 Zadatak 1
Učitati dva broja iz konzole (kao string, pretvoriti u int)
Ispisati rezultat dijeljenja u 7 različitih formata
Obraditi iznimke (npr. dijeljenje s nulom, krivi unos)

Ključne stvari:
int.Parse() pretvara string u int — može baciti FormatException ili OverflowException
(double)a / b — cast na double da ne dobijemo samo cijeli dio
Format D i X rade samo s cjelobrojnim tipovima, pa koristimo a / b

Vjezba1 Zadatak2:
long varijablu s maksimalnom vrijednošću (long.MaxValue)
Pokušati je dodijeliti int varijabli
Uhvatiti OverflowException pomoću checked bloka

Ključna stvar — checked:
Bez checked: C# tiho "odreže" broj i da krivi rezultat bez greške
S checked: program baci OverflowException i mi možemo reagirati

Vjezba1 zadatak3:
Zadatak 3 — Bankovni program s enumom i strukturom
Što trebamo:

enum za vrstu računa
struct BankAccount s tri polja
Polje od 5 elemenata
Izbornik: upis novog / ispis svih (foreach)

Ključne stvari:

enum vrijednosti su zapravo brojevi (0, 1, 2) — (VrstaRacuna)int.Parse(...) pretvara broj u enum
struct je vrijednosni tip — dodjela kopira podatke, ne referencu
foreach prolazi kroz cijelo polje (svih 5 mjesta), pa preskačemo prazne provjером null
brojUpisanih prati koliko je računa stvarno upisano










