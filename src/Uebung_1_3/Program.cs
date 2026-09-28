// ------------------------------
// Uebung_1_3
// ------------------------------

using System.Reflection.Metadata.Ecma335;

namespace Uebung_1_3;

class Program
{

static int getNote(int[] points, string[] names)
    {
        int punkte = 0;
        int note = 0;

        for(int i = 0; i < 3; i++)
        {
            punkte = 
        }

        if(punkte < 12)
        {
            note = 5;
        }

        else if(punkte >= 12 && punkte < 15)
        {
            note = 4;
        }

        else if(punkte >= 15 && punkte < 18)
        {
            note = 3;
        }

        else if(punkte >= 18 && punkte < 21)
        {
            note = 2;
        }

        else if(punkte >= 21 && punkte <= 24)
        {
            note = 1;
        }

        for(int i = 0; i < 3; i++)
        {
            Console.WriteLine($"{names[i]} - {note}");
        }

    }

    static void Main(string[] args)
    {
        string[] namen = {"Mayer","Huber","Gruber"};
        int[] punkte = {21,18,15};
        int points = 0;
        
    }
}
