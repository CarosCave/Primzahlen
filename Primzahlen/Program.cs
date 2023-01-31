using System.Diagnostics;

int primZahlStart = 1;
int primZahlEnde = 500000;
int tempZähler = 0;

int aktuellZuPrüfendeZahl = primZahlStart;

Stopwatch stopWatch = new Stopwatch();
stopWatch.Start();

Console.WriteLine($"Teste Primzahlen für {primZahlEnde} Zahlen.");
Console.WriteLine("Start For-Schleife");
for (int i = 0; i < primZahlEnde; i++)
{
    for (int j = primZahlStart; j <= aktuellZuPrüfendeZahl; j++)
    {
        if ((aktuellZuPrüfendeZahl % j) == 0)
        {
            tempZähler++;
        }  
    }

    if (i % 20000 == 0)
    {
        Console.Write(".");
    }
    
    if (tempZähler == 1 || tempZähler == 2)
    {
        //Console.Write(aktuellZuPrüfendeZahl + ", ");
    }
    aktuellZuPrüfendeZahl++;
    tempZähler = 0;
}

Console.WriteLine();
Console.WriteLine("Ende For-Schleife");
stopWatch.Stop();

TimeSpan timeFor = stopWatch.Elapsed;

Console.WriteLine();


stopWatch.Reset();

stopWatch.Start();
Console.WriteLine("Start Funktionsschleife");

for (int i = 1; i < primZahlEnde; i++)
{
    if (IstPrimzahl(i))
    {
        //Console.Write(i + ", ");
    }
    if (i % 20000 == 0)
    {
        Console.Write(".");
    }
}
stopWatch.Stop();

TimeSpan timeFunc = stopWatch.Elapsed;
Console.WriteLine();
Console.WriteLine("Ende Funktionsschleife");
Console.WriteLine();
Console.WriteLine("For Schleife: \t\t" + timeFor);
Console.WriteLine("Funktionsschleife: \t" + timeFunc);




bool IstPrimzahl(int zuPrüfendeZahl)
{
    int tempZähler = 0;
    for (int i = 1; i <= zuPrüfendeZahl; i++)
    {
        if ((zuPrüfendeZahl % i) == 0)
        {
            tempZähler++;
        }

        if (tempZähler>2)
        {
            return false;
        }
    }

    return true;
}