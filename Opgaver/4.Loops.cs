using System;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Channels;

namespace Opgaver
{
    public class Loops
    {
        public static void Run()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Velkommen til opgaver omkring Loops både med og uden datastrukturer!");
            //Loop1();
            //Loop2();
            //Loop3();
            //Loop4();
            //Loop5();
            //Loop6();
            //Loop7();
            //Loop8();
            //Loop9();
            Loop10();
            BankeBøf();
            MiniProjektLommeregner();
        }

        public static void Loop1()
        {
            Console.WriteLine("Opgave 1:");
            Console.WriteLine("Brug et loop til at udskrive tallene fra 1 til 10.");
            // Lav opgaven herunder!
            for (int Counter1 = 0; Counter1 < 11; Counter1++)
            {
                Console.WriteLine("Antal = " + Counter1);
            }
        }

        public static void Loop2()
        {
            Console.WriteLine("Opgave 2:");
            Console.WriteLine("Brug et loop og en if-betingelse til at udskrive alle lige tal fra 2 til 20.");
            // Lav opgaven herunder!
            int EqualCounter = 0;
            while (EqualCounter <= 20)
            {
                if (EqualCounter % 2 == 0)
                {
                    Console.WriteLine(+EqualCounter);
                }
                EqualCounter++;
            }
        }

        public static void Loop3()
        {
            Console.WriteLine("Opgave 3:");
            Console.WriteLine("Brug et loop til at lægge alle tal fra 1 til 100 sammen og udskriv resultatet.");
            // Lav opgaven herunder!
            int CountToHundred = 0;
            int CountToHundredTotal = 0;

            do
            {
                CountToHundredTotal += CountToHundred;
                CountToHundred++;
            } while (CountToHundred <= 100);

            Console.WriteLine($"Summen er {CountToHundredTotal}");
        }

        public static void Loop4()
        {
            Console.WriteLine("Opgave 4:");
            Console.WriteLine("Bed brugeren om at indtaste sit navn og et tal. Udskriv navnet det antal gange ved hjælp af et loop.");
            // Lav opgaven herunder!
            Console.WriteLine("Indtast dit navn");
            string NameInput = Console.ReadLine();
            Console.WriteLine("Hvor mange gange skal det udskrives?");
            int NoInput = int.Parse(Console.ReadLine());

            for (int i = 0; i < NoInput; i++)
            {
                Console.WriteLine(NameInput);
            }
            Console.WriteLine("Færdig!");

        }

        public static void Loop5()
        {
            Console.WriteLine("Opgave 5:");
            Console.WriteLine("Bed brugeren om at indtaste et tal. Brug et loop til at udskrive alle tal fra det indtastede tal og ned til 1.");
            // Lav opgaven herunder!
            Console.WriteLine("Indtast det tal du vil have talt ned fra!");
            int CountDownInput = int.Parse(Console.ReadLine());

            for (int Cd = CountDownInput; Cd >= 1; Cd--)
            {
                Console.WriteLine(Cd);
            }
            Console.WriteLine("Færdig!");


        }

        public static void Loop6()
        {
            Console.WriteLine("Opgave 6:");
            Console.WriteLine(@"Brug et loop til at udskrive alle bogstaverne i dit navn (ét bogstav pr. linje). 
            Navnet skal være gemt i en string variabel.");
            // Lav opgaven herunder!
            Console.WriteLine("Indtast dit navn og få afvide hvor mange bogstaver der er i det!");
            string NameLength = Console.ReadLine();

            for (int i = 0; i < NameLength.Length; i++)
            {
                Console.WriteLine(NameLength[i] + " " + i);
            }
        }

        public static void Loop7()
        {
            Console.WriteLine("Opgave 7:");
            Console.WriteLine("Brug et loop til at tælle, hvor mange gange bogstavet 'a' optræder i en tekst, som brugeren indtaster.");
			// Lav opgaven herunder!
			Console.WriteLine("Her skal du skrive den tekst du vil have bogstavet A optalt i");
            string HowManyAInput = Console.ReadLine();
            int count = 0;

            foreach (char a in HowManyAInput)
            {
                if (char.ToUpper(a) == 'A')
                {
                    count++;
                }
            }
			Console.WriteLine($"Antallet af bogstavet a i din tekst er: {count}");
        }

        public static void Loop8()
        {
            Console.WriteLine("Opgave 8:");
            Console.WriteLine("Brug et loop til at udskrive alle ulige tal mellem 1 og 50.");
			// Lav opgaven herunder!
			int EqualCounter = 0;
			while (EqualCounter <= 50)
			{
				if (EqualCounter % 2 == 1)
				{
					Console.WriteLine(+EqualCounter);
				}
				EqualCounter++;
			}
		}

        public static void Loop9()
        {
            Console.WriteLine("Opgave 9:");
            Console.WriteLine("Bed brugeren om at indtaste 5 tal (ét ad gangen). Brug et loop til at lægge dem sammen og udskriv summen til sidst.");
            // Lav opgaven herunder!
          decimal counterSum = 0;


            for (int InputCounter = 0; InputCounter < 5; InputCounter++)
            {
                Console.WriteLine("Indtast et tal!");
                decimal CounterInput = Convert.ToDecimal(Console.ReadLine());
                counterSum += CounterInput;
            }
            Console.WriteLine($"Summen af dine tal er: {counterSum}");

        }
        public static void Loop10()
        {
            Console.WriteLine("Opgave 10:");
            Console.WriteLine("Lav et program, hvor brugeren skal gætte et hemmeligt tal mellem 1 og 1000. Brug et loop, så brugeren kan gætte indtil det rigtige tal er fundet.");
            // Lav opgaven herunder!
            Console.WriteLine("Du skal gætte et tal mellem 1 og 1000");

            Random RNGenerator = new Random();
            int RNGNumber = RNGenerator.Next(1, 1001);
            int GuessInput = Convert.ToInt32(Console.ReadLine());

            while (GuessInput != RNGNumber)
            {
                while (GuessInput < RNGNumber)
                {
                    Console.WriteLine("For lavt!");
                    GuessInput = Convert.ToInt32(Console.ReadLine());
                }
                while (GuessInput > RNGNumber)
                {
                    Console.WriteLine("For højt!");
                    GuessInput = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Korrekt, hvor er du god!");
        }

        public static void BankeBøf()
        {
            Console.WriteLine(@"Lav et program med et loop, som udskriver tallene fra 1 til 30. 
            Udskriv 'Banke' hvis tallet er deleligt med 3, 'Bøf' hvis tallet er deleligt med 5 
            og 'BankeBøf' hvis tallet er deleligt med både 3 og 5.");
            // Lav opgaven herunder!
        }
        public static void MiniProjektLommeregner()
        {
            Console.WriteLine("\nMini-projekt: Simpel lommeregner (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine("Lav et program, hvor brugeren indtaster to tal og vælger en regneart (+, -, * eller /).");
            Console.WriteLine("Programmet skal udregne og udskrive resultatet.");
            Console.WriteLine("Tip: Brug if/else eller switch til at vælge regnearten.");
            // Lav opgaven herunder!
        }
    }
}