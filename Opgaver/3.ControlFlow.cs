using System;
using System.ComponentModel.Design;

namespace Opgaver
{
    public class ControlFlow
    {
        public static void Run()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine(
                @"Velkommen til opgaver omkring Control Flow med if, else if og else, 
            Switch og Ternary operator!"
            );
            If1();
            If2();

            Switch1();
            Ternary1();

            MiniProjektQuiz();
            MiniProjektKarakterFeedback();
        }

        public static void If1()
        {
            Console.WriteLine(
                "Lav et program som tjekker om en given værdi er højere eller lavere end 18"
            );
            // Lav opgaven herunder!
            Console.WriteLine("Hvor gammel er du?");
            int HigherOrLower = Convert.ToInt32(Console.ReadLine());
            bool IsHigher = ( HigherOrLower >= 18);

            if (IsHigher)
            {
                Console.WriteLine("Så skal der fandme hakkes stifter");
            }
            else
            {
                Console.WriteLine("Smut hjem og se disney sjov pattebarn");
            }
        }

        public static void If2()
        {
            Console.WriteLine("Lav et program som tjekker om en given værdi er lige eller ulige");
            // Lav opgaven herunder!
            Console.WriteLine("Indtast et tal");
            int EqualOrUnequal = Convert.ToInt32(Console.ReadLine());
            int Leftover = EqualOrUnequal % 2;
            
            if (Leftover == 0)
            {
                Console.WriteLine("Dit tal er lige");
            }
            else
            {
                Console.WriteLine("Dit tal er ulige");
            }
        }

        public static void Switch1()
        {
            Console.WriteLine("Lav et program som tjekker om en given værdi er lige eller ulige");
            // Lav opgaven herunder!
            Console.WriteLine("Indtast et tal");
            String SwEqualInput = Console.ReadLine();
            int SwEqual;

            if (int.TryParse(SwEqualInput, out SwEqual))
            {
                int SwLeftover = SwEqual % 2;

                switch (SwLeftover == 0)
                {
                    case true:
                        Console.WriteLine("Så er den lige");
                        break;
                    case false:
                        Console.WriteLine("Så er den ulige");
                        break;
                    default:
                        Console.WriteLine("Skriv et heltal!!!! Dompap");
                        break;
                }
            }
             else
                {
                    Console.WriteLine("Skriv et heltal!!!! Dompap");
                }
        }

        public static void Ternary1()
        {
            Console.WriteLine("Lav et program som tjekker om en given værdi er lige eller ulige");
            // Lav opgaven herunder!
        }

        public static void MiniProjektQuiz()
        {
            Console.WriteLine("\nMini-projekt: Simpelt quiz-spil (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine(
                "Lav et program, der stiller brugeren tre spørgsmål (du vælger selv spørgsmål og svar)."
            );
            Console.WriteLine("Brugeren skal indtaste sit svar til hvert spørgsmål.");
            Console.WriteLine(
                "Programmet skal tjekke, om svaret er rigtigt eller forkert, og til sidst udskrive, hvor mange rigtige brugeren fik."
            );
            Console.WriteLine(
                "Tip: Brug variabler til at gemme point og svar, og if/else til at tjekke svarene."
            );
            // Lav opgaven herunder!
        }

        public static void MiniProjektKarakterFeedback()
        {
            Console.WriteLine("\nMini-projekt: Karakter-feedback (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine(
                "Lav et program, hvor brugeren indtaster en karakter (fx 12, 10, 7, 4, 02, 00 eller -3)."
            );
            Console.WriteLine(
                @"Programmet skal give en passende feedback baseret på karakteren, 
            fx 'Super flot!', 'Godt klaret', 'Du kan gøre det bedre' osv."
            );
            Console.WriteLine("Brug if/else eller switch til at vælge feedbacken.");

            Console.WriteLine(
                @"Ekstra opgave: Lav så man indtaster flere karaktere 
            for en bruger og man regner gennemsnittet ud."
            );
            // Lav opgaven herunder!
        }
    }
}
