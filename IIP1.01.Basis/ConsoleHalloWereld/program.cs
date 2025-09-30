using System;

namespace ConsoleNaamVanDeOefening
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.Write("Wat is je voornaam?: "); 
		 string voornaam = Console.ReadLine();
		 
		 Console.Write("Hoe oud ben je?: "); 
		 string antwoord = Console.ReadLine();
		 int leeftijd = Convert.ToInt32(antwoord);

		 
		 Console.Write("Geef je lievelingsletter: "); 
		 string lievelingsletter = Console.ReadLine();
		 
		Console.WriteLine("");
		Console.WriteLine($"Hallo {voornaam}. Jij bent {leeftijd}  jaar."); 
		Console.WriteLine($"Volgend jaar ben je {(leeftijd + 1)}");
		Console.WriteLine($"Jouw lievelingsletter is: {lievelingsletter}"); 
		
		
      }
   }
}
