using System;
using System.Collections.Generic;

namespace JeuDuPendu
{
    class Program
    {
        static void Main(string[] args)
        {
            string mot = "bEleu";

            AfficherMot(mot, new List<char> { 'E', 'B' });
            char lettre = DemanderLettre();
            Console.WriteLine($"Vous avez entré la lettre : {lettre}");
            // DevinerMot();
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

        static char DemanderLettre()
        {
            char lettre;
            string reponse;

            do
            {
                Console.Write("Entrez une lettre : ");
                reponse = Console.ReadLine();

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
            } while (true); // Boucle jusqu'à ce qu'une lettre valide soit saisie
        }
    }
}
