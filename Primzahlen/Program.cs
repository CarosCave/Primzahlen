using System.Diagnostics;

int primZahlStart = 1;
int primZahlEnde = 1000;
int tempZähler = 0;

int aktuellZuPrüfendeZahl = primZahlStart;

Stopwatch stopWatch = new Stopwatch();
stopWatch.Start();

for (int i = 0; i < primZahlEnde; i++)
{
    for (int j = primZahlStart; j <= aktuellZuPrüfendeZahl; j++)
    {
        if ((aktuellZuPrüfendeZahl % j) == 0)
        {
            tempZähler++;
        }  
    }

    if (tempZähler == 1 || tempZähler == 2)
    {
        Console.Write(aktuellZuPrüfendeZahl + ", ");
    }
    aktuellZuPrüfendeZahl++;
    tempZähler = 0;
}

stopWatch.Stop();

Console.WriteLine();
Console.WriteLine(stopWatch.Elapsed);
