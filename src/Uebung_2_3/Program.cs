// ------------------------------
// Uebung_2_3
// ------------------------------

using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace Uebung_2_3;

class Daten
{
    private string kontoinhaber;
    private double kontostand;
    private double zinssatz;

    public Daten (string kontoinhaber, double kontostand, double zinssatz)
    {
        this.kontoinhaber = kontoinhaber;
        this.kontostand = kontostand;
        this.zinssatz = zinssatz;
    }

    public override string ToString()
    {
    return "Kontoinhaber: " + kontoinhaber +
           "\nKontostand: " + kontostand + " Euro" +
           "\nZinssatz: " + zinssatz + "%";
    }

    public double Ein (double betrag)
    {
        kontostand = kontostand + betrag;
        
        return kontostand;
    }

    public double Aus (double betrag)
    {
        kontostand = kontostand - betrag;
        
        return kontostand;
    }

    public double JahresAbschluss (double zinsen)
    {
        zinsen = kontostand * zinssatz;
        kontostand = kontostand + zinsen;

        return zinsen;
    }

}
    

class Program
{
    static void Main(string[] args)
    {
        Daten peter = new Daten("Peter Petricevic", 400, 1.03);
        
        Console.WriteLine ("")


    }
}
