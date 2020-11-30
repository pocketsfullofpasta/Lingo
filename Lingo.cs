using System;
using System.Linq;

namespace Lingo
{
    class Lingo
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Esi sveicināts spēlē LINGO!\nTavs uzdevums ir uzminēt vārdu piecu burtu garumā, neizmantojot garuma un mīkstinājuma zīmes.\n" +
                "Ja vairs spēlēt nevēlies, tad ieraksti konsolē vārdu apnika un nospied ENTER.");




            string minamais = Lingo.Saraksts();
            string atminets = minamais[0] + "****";
            
            do
            {
                string minejums = Lingo.inputMinejums();


                if (minejums == "apnika")
                    break;

                if (minejums.Length < 5 || minejums.Length > 5)
                {
                    Console.WriteLine("Kļūda vārda ievadē!");
                    continue;
                }

                minamais = Zvaigznes(minejums, minamais, atminets);

            }
            while (Lingo.Uzvara(atminets));
            

        }

        private static string Saraksts()
        {
            string[] word = { "viens", "pieci", "siers", "maize", "krams", "tilts" };
            Random randoms = new Random();
            int index = randoms.Next(word.Length);

            return (word[index]);
        }

        public static char[] Zvaigznes(string ievade, string uzmini, char[] atminets)
        {
            for (int i = 1; i < uzmini.Length; i++)
            {
                if (ievade[i] == uzmini[i] && atminets[i] == '*')
                {
                    atminets[i] = ievade[i];
                }
            }

            return atminets;
        }
        public static string inputMinejums()
        {
            Console.WriteLine();
            Console.Write("Ievadi vārdu: ");
            string minejums = Console.ReadLine().Trim().ToLower();
            if (!minejums.Contains("*"))
                Console.ForegroundColor = ConsoleColor.Green;

            return minejums;
        }

        public static bool Uzvara(string atminets)
        {

            if (atminets.IndexOf('*') == -1)
            {
                Console.WriteLine("Apsveicu, Tu uzvarēji!");
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
