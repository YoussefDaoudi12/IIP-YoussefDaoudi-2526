using System;

namespace ConsoleNaamVanDeOefening
{
   class Program
   {
      static void Main(string[] args)
      {
        
		Console.WriteLine(@"
**********************
│GANGSTA NAME BUILDER│
**********************");
		
		Console.WriteLine(" ");
		
		Console.Write("Give the first name of any Disney character: ");
		string gangsterName = Console.ReadLine();

		Console.Write("Give any workbench tool: ");
		string tool = Console.ReadLine();
		
		Console.Write("What is your last name? : ");
		string lastName = Console.ReadLine();
  
		Console.WriteLine("Your gangsta name is " + gangsterName + " \"" + tool + "\" " + lastName);
		}
  }
  
}
