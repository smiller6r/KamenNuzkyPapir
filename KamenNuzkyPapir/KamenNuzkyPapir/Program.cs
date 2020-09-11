using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KamenNuzkyPapir {
    class Program {
        static void Main(string[] args) {
            double rndnum;
            int Points, PcPoints;
            string PCkeyword, UserKeyword, Continue;
            PCkeyword = UserKeyword = Continue = "";
            bool PlayAgain = true;
            Points = PcPoints = 0;

            while (PlayAgain == true) {
                do {
                    Console.WriteLine("Kámen, Nůžky, Papír?");
                    UserKeyword = Console.ReadLine();
                } while ((UserKeyword != "kamen") && (UserKeyword != "nuzky") && (UserKeyword != "papir"));

                Random r = new Random();
                rndnum = r.Next(1, 4);
                switch (rndnum) {
                    case 1: PCkeyword = "Kámen"; break;
                    case 2: PCkeyword = "Nůžky"; break;
                    case 3: PCkeyword = "Papír"; break;
                }
                Console.WriteLine('\n' + "PC vylosoval " + PCkeyword + '\n');

                if ((UserKeyword == "kamen") && (PCkeyword == "Nůžky")) {
                    Console.WriteLine("Vyhral jsi ! \n");
                    Points += 1;
                }
                else if ((UserKeyword == "kamen") && (PCkeyword == "Papír")) {
                    Console.WriteLine("Prohral jsi ! \n");
                    PcPoints += 1;
                }
                else if ((UserKeyword == "kamen") && (PCkeyword == "Kámen"))
                    Console.WriteLine("Remiza ! \n");

                else if ((UserKeyword == "nuzky") && (PCkeyword == "Papír")) {
                    Console.WriteLine("Vyhral jsi ! \n");
                    Points += 1;
                }
                else if ((UserKeyword == "nuzky") && (PCkeyword == "Kámen")) {
                    Console.WriteLine("Prohral jsi ! \n");
                    PcPoints += 1;
                }
                else if ((UserKeyword == "nuzky") && (PCkeyword == "Nůžky"))
                    Console.WriteLine("Remiza ! \n");

                else if ((UserKeyword == "papir") && (PCkeyword == "Kámen")) {
                    Console.WriteLine("Vyhral jsi ! \n");
                    Points += 1;
                }
                else if ((UserKeyword == "papir") && (PCkeyword == "Nůžky")) {
                    Console.WriteLine("Prohral jsi ! \n");
                    PcPoints += 1;
                }
                else if ((UserKeyword == "papir") && (PCkeyword == "Papír"))
                    Console.WriteLine("Remiza !");

                Console.WriteLine(Points + " : " + PcPoints);
                if (Points > PcPoints)
                    Console.WriteLine("Vyhráváš ! \n");
                else if (Points < PcPoints)
                    Console.WriteLine("Prohráváš ! \n");
                else if (Points == PcPoints)
                    Console.WriteLine("Remiza ! \n");

                do {
                    Console.WriteLine("\nChceš pokračovat? \t A/N");
                    Continue = Console.ReadLine();
                    if ((Continue == "a") || (Continue == "A"))
                        PlayAgain = true;
                    else if ((Continue == "n") || (Continue == "N"))
                        PlayAgain = false;
                } while ((Continue != "a") && (Continue != "n") && (Continue != "A") && (Continue != "N"));

            }
        }
    }
}
