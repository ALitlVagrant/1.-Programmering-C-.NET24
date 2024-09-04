Console.WriteLine("Hur mycket tjänar du i timmen");
int timLön = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Vad heter produkten du köpt?");
string produkt = Console.ReadLine();

Console.WriteLine("Hur många antal av denna produkt har du köpt? ");
int antal = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Hur mycket kostar den produkt du spenderat pengar på? ; ");
int kostnad = Convert.ToInt32(Console.ReadLine());

float totalkostnad = antal * kostnad;
float timmar = totalkostnad / timLön;
Console.WriteLine("Du behöver jobba " + Math.Round(timmar,2) + " antal timmar för att ha råd med " + antal + " " + produkt + " du köpt.");

