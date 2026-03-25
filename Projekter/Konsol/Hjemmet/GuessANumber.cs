namespace Hjemmet
{
    public class GuessANumber
    {
        public void Start()
        {
			Random random = new Random();
			int numberToGuess = random.Next(1, 101);
			Console.WriteLine("Velkommen til Gæt et tal!");
			Console.WriteLine("Jeg har valgt et tal mellem 1 og 100. Kan du gætte det?");
			int userGuess = 0;
			while (true)
			{
				Console.Write("Indtast dit gæt: ");
				string input = Console.ReadLine();

				if (int.TryParse(input, out userGuess))
				{
					if (userGuess < numberToGuess)
					{
						Console.WriteLine("For lavt! Prøv igen.");
					}
					else if (userGuess > numberToGuess)
					{
						Console.WriteLine("For højt! Prøv igen.");
					}
					else
					{
						Console.WriteLine("Tillykke! Du gættede det rigtige tal!");
						break; 
					}
				}
				else
				{
					Console.WriteLine("Ugyldigt input. Indtast venligst et tal.");
				}
			}

			Console.ReadLine(); 
		}
    }
}
