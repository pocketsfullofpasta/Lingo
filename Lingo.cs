using System;
using System.Linq;

namespace Lingo
{
    class Lingo
    {
        public static void Main(string[] args)
        {
            newGame:
            Console.WriteLine("Esi sveicināts spēlē LINGO!\nTavs uzdevums ir uzminēt vārdu piecu burtu garumā, neizmantojot garuma un mīkstinājuma zīmes.\n" +
                "Ja vairs spēlēt nevēlies, tad ieraksti konsolē vārdu apnika un nospied ENTER.");

            
            

            string minejums;
            do
            {
                Console.WriteLine();
                Console.Write("Ievadi vārdu: ");
                minejums = Console.ReadLine().Trim().ToLower();

                if (minejums == "apnika")
                    break;

                if (minejums.Length < 5 || minejums.Length > 5)
                {
                    Console.WriteLine("Kļūda vārda ievadē!");
                    continue;
                }
                if (Lingo.Uzvara())
                {
                    Console.WriteLine("Apsveicu, tu uzminēji!");
                    goto newGame;
                }

                Lingo.Zvaigznes();
                Lingo.inputMinejums();
            } 
            while (minejums == "apnika");    
        }

        private static string Saraksts()
        {
            string[] word = { "viens", "pieci", "siers", "maize", "krams", "tilts" };
            Random randoms = new Random();
            int index = randoms.Next(word.Length);

            return (word[index]);
        }

        public static char[] Zvaigznes()
        {
            char[] stars = Lingo.Saraksts().ToCharArray();

            for (int i = 1; i < stars.Length; i++)
            {
                stars[i] = '*';
            }
            
            return stars;
        }
        public static char[] inputMinejums()
        {
            Console.WriteLine();
            Console.Write("Ievadi vārdu: ");
            string minejums = Console.ReadLine().Trim().ToLower();
            char[] guess = minejums.ToCharArray();
            return guess;
        }

        public static char[] Progress()
        {
 
            var intersect = Lingo.Saraksts().Intersect(Lingo.inputMinejums());

            foreach (int value in intersect)
            {
                Console.WriteLine(value);
               
            }
        }

        public static bool Uzvara()
        {

            if (Lingo.Saraksts().Length != Lingo.inputMinejums().Length) 
                return false; 
            
            for (int i = 0; i < Lingo.Saraksts().Length; i++)
            {
                if (Lingo.Saraksts()[i] != Lingo.inputMinejums()[i]) 
                    return false;     
            }
            return true;
        }
        
    }
} 
