using System;
using System.Diagnostics.Metrics;

namespace Opgaver
{
    public class Inputs
    {

        public static void Run()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Velkommen til opgaver omkring Expressions, Operators og Inputs!");
            String1();
            Int1();
            Double1();
            Bool1();

            // Mini-projekter til inspiration:
            MiniProjekt1();
            MiniProjekt2();
        }

        public static void String1()
        {
            Console.WriteLine(
                "Lav et program som gemmer et input som en string og skriver strengen ud i konsollen"
            );

            Console.WriteLine("Indtast en streng: ");
            // Lav opgaven herunder!
            Console.WriteLine("Indtast dit navn:");
            string? DitNavn = Console.ReadLine();

            Console.WriteLine("Hej, " + DitNavn + "!");
        }

        public static void Int1()
        {
            Console.WriteLine(
                "Lav et program som gemmer et input som et tal og skriver tallet ud i konsollen"
            );

            // Lav opgaven herunder!
            Console.WriteLine("Hvor gammel er du? ");
            int AldersInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Din alder er " + AldersInput);
        }


        public static void Double1()
        {
            Console.WriteLine(
                "Lav et program som gemmer et input som et decimaltal og skriver tallet ud i konsollen"
            );

            // Lav opgaven herunder!
            Console.WriteLine("Indtast din højde: ");
            decimal HoejdeInput = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Du er " + HoejdeInput + " meter høj");
        }

        public static void Bool1()
        {
            Console.WriteLine(
                "Lav et program som gemmer et input som en sandhedsværdi og skriver værdien ud i konsollen"
            );

            // Lav opgaven herunder!
            Console.WriteLine("Indtast en sandhedsværdi (True/False): ");
            bool SandtEllerFalsk = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine(SandtEllerFalsk);
        }
        // Mini-projekt: Personlig profil (skabelon)
        public static void MiniProjekt1()
        {
            Console.WriteLine("\nMini-projekt: Personlig profil (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine("Lav et program, hvor brugeren indtaster sit navn, alder og hjemby.");
            Console.WriteLine(
                "Gem oplysningerne i variabler og udskriv en præsentationstekst, der bruger alle oplysningerne."
            );
            Console.WriteLine("Eksempel: Hej, jeg hedder X, er X år gammel og kommer fra X!");
            // Lav opgaven herunder!
            Console.WriteLine("Hej, hvad hedder du?");
            string? NavnInput = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Hvor gammel er du?");
            string? AldersInput = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Til sidst hvor bor du?");
            string? ByInput = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Hej, jeg hedder " + NavnInput + ", er " + AldersInput + " år gammel og kommer fra " + ByInput + "! " );
				}

        // Mini-projekt 2: BMI-beregner (skabelon)
        public static void MiniProjekt2()
        {
            Console.WriteLine("\nMini-projekt 2: BMI-beregner (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine(
                "Lav et program, hvor brugeren indtaster sin vægt (i kg) og højde (i meter)."
            );
            Console.WriteLine("Programmet skal beregne brugerens BMI og udskrive resultatet.");
            Console.WriteLine(
                "Tip: BMI beregnes som vægt divideret med højde i anden (BMI = vægt / (højde * højde))."
            );
            Console.WriteLine("Hvor meget vejer du?");
            decimal Vaegt = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Hvad er din højde i meter?");
            decimal Hoejde = Convert.ToDecimal(Console.ReadLine());
            decimal BMI = Vaegt / (Hoejde * Hoejde);
            Console.WriteLine("Din BMI er " + Math.Round(BMI, 2) + ". ");
        }
    }
}
