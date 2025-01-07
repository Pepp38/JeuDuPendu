using System;
using System.Collections.Generic;
using AsciiArt;

namespace JeuDuPendu
{
    class Program
    {
        static void Main(string[] args)
        {
            string mot = "Jouet";
            DevinerMot(mot.ToUpper());
        }

        static void DevinerMot(string mot)
        {
            List<char> lettres = new List<char> {};
            List<char> mauvaisesLettres = new List<char> {};
            Console.WriteLine(Ascii.PENDU[0]);
            AfficherMot(mot, lettres);
            Console.WriteLine();
     
            const int NB_Vies = 6;
            int viesRestantes = NB_Vies;

            while(true)
            {         
                char lettre = DemanderLettre(); 

                if(mot.Contains(lettre))
                {
                    Console.WriteLine($"Le mot contient la lettre {lettre}!\n");
                    lettres.Add(lettre);
                    bool asWon = MotDeviner(mot,lettres);

                    if(asWon)
                    {
                        Console.WriteLine($"Le mot est {mot}, vous avez gagné!\n\n");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine($"Le mot ne contient pas la lettre {lettre}...");
                    if (!mauvaisesLettres.Contains(lettre))
                    {
                        mauvaisesLettres.Add(lettre);
                    }
                    viesRestantes--;
                    Console.WriteLine($"Vies restantes : {viesRestantes}\n");
                }
                
                if(viesRestantes==0) 
                {
                    Console.WriteLine(Ascii.PENDU[NB_Vies-viesRestantes]);
                    Console.WriteLine($"Vous avez perdu! Le mot était {mot}!\n\n");
                    break;
                }

                Console.WriteLine(Ascii.PENDU[NB_Vies-viesRestantes]);
                AfficherMot(mot, lettres);
                Console.WriteLine();
                Console.WriteLine($"Essais : {String.Join(", ", mauvaisesLettres)}");
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

        static bool MotDeviner(string mot, List<char> lettres)
        {
            // Parcourt chaque lettre du mot
            for (int i = 0; i < mot.Length; i++)
            {
                // Vérifie si la lettre actuelle du mot est dans la liste des lettres trouvées
                if (!lettres.Contains(mot[i]))
                {
                    // Si une lettre n'est pas trouvée, le mot n'est pas encore deviné
                    return false;
                }
            }

            // Si toutes les lettres du mot sont trouvées dans la liste, le mot est deviné
            return true;
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
