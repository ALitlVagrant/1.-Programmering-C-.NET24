using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Excercise
{
    //Skapar klassen bok med ritningar i
    public class Bok
    {
        public string Titel;
        public string Författare;
        public int UtgivningsÅr;
        public string Genre;


        //Skapar en metod som beskriver boken
        public void Beskrivning()
        {
            Console.WriteLine($"Titel: {Titel}");
            Console.WriteLine($"Författare: {Författare}");
            Console.WriteLine($"Utgivningsår {UtgivningsÅr}");
            Console.WriteLine($"Genre: {Genre}");

        }
    }
    class TheBloodMeridian : Bok
    {
        public TheBloodMeridian()
        {
            Titel = "The Blood Meridian";
            Författare = "Cormac Mc Carthy";
            UtgivningsÅr = 1985;
            Genre = "Horror";

        }

    }
}
