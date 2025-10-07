using System;

namespace ConsoleContactCard
{
   class Program
   {
      static void Main(string[] args)
      {
          string naam = "Bobby Peru";
          bool gehuwd = true;
          string telefoon = "0486/33.22.19";
          int leeftijd = 25;
          decimal salaris = 2500.00m; // decimal voor geld
          char geslacht = 'm';
          double lengte = 1.75;

          string gehuwdTekst = gehuwd ? "Ja" : "Nee";

          Console.ForegroundColor = ConsoleColor.Yellow;

          Console.WriteLine($@"
----------------
*
* Naam: {naam}
* Gehuwd: {gehuwdTekst}
* Telefoon: {telefoon}
* Leeftijd: {leeftijd} jaar
* Salaris: {salaris:C} per maand
* Geslacht: {geslacht}
* Lengte: {lengte:F2}m
*
----------------
");

          Console.ResetColor();
          Console.WriteLine("Druk op een toets om verder te gaan...");
          Console.ReadKey();
      }
   }
}

