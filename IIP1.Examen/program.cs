using System;

namespace ConsoleSnoepmachine 
{
   class Program
   {
      static void Main(string[] args)
    {
		
		const decimal PRIJS_DRANK = 2.00m;
		const decimal PRIJS_SNOEP = 1.50m;
		int saldo = 0;
		
        Console.Write("SNOEPMACHINE 🍭🥤");
		
		Console.WriteLine();
		Console.WriteLine("a. geld inwerpen");
		Console.WriteLine($"b. drank kopen ({PRIJS_DRANK})");
		Console.WriteLine($"c. snoep kopen ({PRIJS_SNOEP})");
		Console.WriteLine("d. stoppen");
		char keuze = Convert.ToChar(Console.ReadLine());
		
		
				
		switch (keuze) {
			
        case 'a':
            Console.Write("Inworp: ");
            int inworp = Convert.ToInt32(Console.ReadLine());
            if (inworp % 5)
			{
				saldo = saldo + inworp;
				Console.Write($"Huidige saldo: {saldo} "); 
				for (int i = 0; i < saldo; i++);
				Console.Write("🪙");
				
            }
            else 
			{
				Console.Write("Alleen muntstukken van 0.5 euro of veelvouden daarvan zijn toegelaten");
				
			}
			break;
			
        case 'b':
				Console.WriteLine("Je drankje komt eraan!");
				saldo = saldo - PRIJS_DRANK;
		break;
		
        case 'c':
				Console.WriteLine("Je snoepje komt eraan!");
				saldo = saldo - PRIJS_SNOEP;
		break;

		
        case 'd':
			Console.Write($"je krijgt {saldo} terug.");
            break;

        default:
            Console.WriteLine();
            Console.WriteLine($"'{keuze}' is geen geldige keuze, druk op een toets om verder te gaan...");
            Console.ReadKey();
            break;
    }

	}
   }
  
}
