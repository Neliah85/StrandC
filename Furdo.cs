using System;
using System.Linq;

public class Furdo
{
    public string Nev { get; }
    public string Cim { get; }
    public int Ar { get; }
    public int Vizhofok { get; }

    public Furdo(string sor)
    {
        string[] adatok = sor.Split(';');
        Nev = adatok[0];
        Cim = adatok[1];
        Ar = int.Parse(adatok[2]);
        Vizhofok = int.Parse(adatok[3]);
    }

    public string IRSZ()
    {
        return Cim.Substring(0, 4);
    }

    public string Telepules()
    {
        string[] reszek = Cim.Split(' ');
        int vesszoIndex = Array.IndexOf(reszek, reszek.FirstOrDefault(r => r.Contains(',')));
        if (vesszoIndex > 1)
        {
            return string.Join(" ", reszek.Skip(1).Take(vesszoIndex - 1));
        }
        else if (vesszoIndex == 1)
        {
            return reszek[1].TrimEnd(',');
        }
        return string.Empty; // Ha nem talál települést
    }
}