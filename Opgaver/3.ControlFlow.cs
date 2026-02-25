using System;
using System.ComponentModel.Design;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Threading.Tasks.Sources;

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
            //If1();
            //If2();

            //Switch1();
            //Ternary1();

            //MiniProjektQuiz();
            MiniProjektKarakterFeedback();
        }

        //      public static void If1()
        //      {
        //          Console.WriteLine(
        //              "Lav et program som tjekker om en given værdi er højere eller lavere end 18"
        //          );
        //          // Lav opgaven herunder!
        //          Console.WriteLine("Hvor gammel er du?");
        //          string HigherOrLower = Console.ReadLine();

        //          if (decimal.TryParse(HigherOrLower, out decimal HoLValue))
        //      {
        //          if (HoLValue >= 18)
        //          {
        //              Console.WriteLine("Så skal der fandme hakkes stifter!");
        //          }
        //          else
        //          {
        //              Console.WriteLine("Smut hjem og se disney sjov pattebarn");
        //          }
        //      }
        //      else 
        //      {
        //              Console.WriteLine("Skriv et fucking heltal");            
        //      }

        //      }

        //      public static void If2()
        //      {
        //          Console.WriteLine("Lav et program som tjekker om en given værdi er lige eller ulige");
        //          // Lav opgaven herunder!
        //          Console.WriteLine("Indtast et tal");
        //          int EqualOrUnequal = Convert.ToInt32(Console.ReadLine());
        //          int Leftover = EqualOrUnequal % 2;

        //          if (Leftover == 0)
        //          {
        //              Console.WriteLine("Dit tal er lige");
        //          }
        //          else
        //          {
        //              Console.WriteLine("Dit tal er ulige");
        //          }
        //      }

        //      public static void Switch1()
        //      {
        //          Console.WriteLine("Lav et program som tjekker om en given værdi er lige eller ulige");
        //          // Lav opgaven herunder!
        //          Console.WriteLine("Indtast et tal");
        //          string SwEqual = Console.ReadLine();

        //          switch (int.TryParse(SwEqual, out int Leftover))
        //          {
        //              case true:
        //                  switch (Leftover %2)
        //                  {
        //                      case 0:
        //                          Console.WriteLine("Så er den lige");
        //                          break;

        //                      default:
        //                          Console.WriteLine("Så er den ulige");
        //                          break;
        //                  }
        //                  break;

        //              case false:
        //                  Console.WriteLine("Skriv et heltal mongolos");
        //                  break;
        //          }


        //      }

        //      public static void Ternary1()
        //      {
        //          Console.WriteLine("Lav et program som tjekker om en given værdi er lige eller ulige");
        //	// Lav opgaven herunder!
        //	Console.WriteLine("Indtast et tal");
        //          bool TnEqualInput = int.TryParse(Console.ReadLine(), out int TnLeftover);

        //          string TnEqualResult = TnEqualInput
        //              ? (TnLeftover % 2 == 0 ? "Lige" : "Ulige")
        //              : "Skriv nu et fucking heltal din klaphat";

        //          Console.WriteLine(TnEqualResult);
        //}

        //      public static void MiniProjektQuiz()
        //      {
        //          // Lav opgaven herunder!
        //          int Score = 0;
        //          Console.WriteLine("Hvor mange sæsoner er der af FRIENDS? Angives som heltal.");
        //         string Answer1 = Console.ReadLine();
        //      if (Answer1.Trim() == "10")
        //          {
        //              Console.WriteLine("Det er fandme rigtigt!");
        //              Score++;
        //          }
        //      else
        //          { 
        //              Console.WriteLine("FORKERT"); 
        //          }

        //          Console.WriteLine("Er Donald Trump pædofil? Ja/Nej");
        //          string Answer2 = Console.ReadLine();
        //	if (Answer2.Trim() == "Ja")
        //	{
        //		Console.WriteLine("Det er fandme rigtigt!");
        //              Score++;
        //	}
        //	else
        //	{
        //		Console.WriteLine("FORKERT");
        //	}

        //          Console.WriteLine("Hvad er hovedstaden i Tyskland? Husk stort begyndelsesbogstav!");
        //              string Answer3 = Console.ReadLine();
        //	if (Answer3.Trim() == "Berlin")
        //	{
        //		Console.WriteLine("Det er fandme rigtigt!");
        //              Score++;
        //	}
        //	else
        //	{
        //		Console.WriteLine("FORKERT");
        //	}
        //	Console.WriteLine($"Du fik {Score}/3 spørgsmål rigtige!");
        //}

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
            //Lav opgaven herunder!
            Console.WriteLine("Hvilken karakter har du fået?");
            int Grade1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Har du fået andre karakterer end den ene?");
            string GradeMeMaybe = Console.ReadLine();

            if (GradeMeMaybe.ToLower() == "nej")
            {


                if (Grade1 >= 10)
                {
                    Console.WriteLine("Godt gået!");
                }
                else if (Grade1 >= 4)
                {
                    Console.WriteLine("Det er ok");
                }
                else if (Grade1 >= -3)
                {
                    Console.WriteLine("Det kan du fandme godt gøre bedre");
                }
            }
            else
            {
				Console.WriteLine("Hvilke karakterer fik du udover");
            }
        
        }
    }
}
