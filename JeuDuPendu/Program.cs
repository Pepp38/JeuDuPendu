using System;
using System.Collections.Generic;

namespace JeuDuPendu
{
    class Program
    {
        static void Main(string[] args)
        {
            string mot = "bEleu";
            DevinerMot(mot.ToUpper());
        }

        static void DevinerMot(string mot)
        {
            List<char> lettres = new List<char> {};
            AfficherMot(mot, lettres);
            Console.WriteLine();

            while(true)
            {         
                char lettre = DemanderLettre(); 

                if(mot.ToUpper().Contains(lettre))
                {
                    Console.WriteLine($"Le mot contient la lettre {lettre}!");
                    lettres.Add(lettre);
                }
                else
                {
                    Console.WriteLine($"Le mot ne contient pas la lettre {lettre}...");   
                }
                
                AfficherMot(mot, lettres);
                Console.WriteLine();

            }               
        }

        static char DemanderLettre()
        {
            char lettre;
            string reponse;

            do
            {
                Console.Write("Entrez une lettre : ");
                reponse = Console.ReadLine();
                Console.Clear();
                
                if (string.IsNullOrEmpty(reponse) || reponse.Length != 1)
                {
                    Console.WriteLine("Veuillez entrer une lettre.");
                }
                else if (!char.IsLetter(reponse[0]))
                {
                    Console.WriteLine("Veuillez entrer uniquement une lettre.");
                }
                else
                {
                    // Si l'entrée est valide, on retourne la lettre
                    lettre = char.ToUpper(reponse[0]);
                    return lettre;
                }
            } while (true); 
        }

        static void AfficherMot(string mot, List<char> lettres)
        {
            for (int i = 0; i < mot.Length; i++)
            {
                if (lettres.Contains(char.ToUpper(mot[i])))
                {
                    Console.Write(mot[i] + " ");
                }
                else
                {
                    Console.Write("_ ");
                }
            }
            Console.WriteLine();
        }
    }
}
