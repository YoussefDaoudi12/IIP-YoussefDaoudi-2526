using System;

namespace ConsoleAbonnement
{
   class Program
   {
      static void Main(string[] args)
      {
		Console.WriteLine("Bestelgegevens"); 
		Console.WriteLine("==============");

		Console.Write("- naam klant: ");
		string klantNaam = Console.ReadLine();

		Console.Write("- aantal toegangsbeurten: ");
		int toegangsBeurten = Convert.ToInt32(Console.ReadLine());

		Console.Write("- prijs (bv. 122,5): ");
		double prijs = Convert.ToDouble(Console.ReadLine());

		Console.Write("- badkledij inbegrepen (typ true of false): ");
		bool badKledij = Convert.ToBoolean(Console.ReadLine());

		Console.Write("- geslacht (m of v): ");
		char geslacht = Console.ReadKey().KeyChar;
		Console.WriteLine();

		Console.WriteLine(" ");
		Console.WriteLine(" ");
		
		var kaartNummer = new Random().Next(100,1000) + "-" + new Random().Next(1000,10000) + "-" + new Random().Next(10,100);
		
		Console.ForegroundColor = ConsoleColor.Yellow;

		Console.WriteLine(@$"
Samenvatting
============
- houder: {klantNaam}
- geslacht: {geslacht}
- prijs: €{prijs}
- aantal beurten: {toegangsBeurten}
- incl. badkledij: {badKledij}
- kaartnummer: {kaartNummer}
");
		Console.ResetColor();

      }
   }
}
      
   

