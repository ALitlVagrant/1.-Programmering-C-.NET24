namespace Inheritance_Excercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kund företagskund = new Företagskund();
            Kund privatkund = new Företagskund();

            företagskund.ÅrsRapport();
            privatkund.ÅrsRapport();
        }
    }
    public class Kund()
    {

        protected string kundTyp;
        protected double saldo;
        protected int kontonummer;
        public void ÅrsRapport()
        {
            Console.WriteLine();
            Console.WriteLine("Årsrapport: ");
            Console.WriteLine($"Kundtyp: {kundTyp}");
            Console.WriteLine($"Saldo: {saldo}");
            Console.WriteLine($"Kontonummer: {kontonummer}");

        }
    }
    class PrivatKund : Kund
    {
        public PrivatKund()
        {
            kundTyp = "Privat kund";
            saldo = 1250;
            kontonummer = 951;
        }

    }
    class Företagskund : Kund
    {
        public Företagskund()
        {
            kundTyp = "Företags kund";
            saldo = 250000;
            kontonummer = 9673;

        }
    }
}
