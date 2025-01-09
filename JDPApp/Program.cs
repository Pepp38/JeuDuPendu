using System;
using System.Collections.Generic;
using System.IO;
using AsciiArt;

namespace JeuDuPendu
{
    class Program
    {
        static void Main(string[] args)
        {
            char reponse;

            do
            {
                Console.Clear();
                string mot = ChargerMot().Trim();

                if (!string.IsNullOrEmpty(mot))
                {
                    DevinerMot(mot.ToUpper());
                }
                else
                {
                    Console.WriteLine("Aucun mot disponible. Le jeu ne peut pas continuer.");
                    break;
                }

                Console.WriteLine("Voulez-vous continuer ? (O/N)");
                reponse = LireReponseUtilisateur();

            } while (reponse == 'O');

            Console.WriteLine("\nMerci d'avoir joué ! À bientôt !");
        }

        static string ChargerMot()
        {
            string[] liste = ChargerListe();

            if (liste.Length == 0)
            {
                Console.WriteLine("La liste des mots est vide !");
                return string.Empty; 
            }

            Random random = new Random();
            int index = random.Next(liste.Length); 
            return liste[index];
        }

        static string[] ChargerListe()
{
    string cheminFichier = "mots.txt";

    try
    {
        if (File.Exists(cheminFichier))
        {
            return File.ReadAllLines(cheminFichier);
        }
        else
        {
            Console.WriteLine("Fichier introuvable. Vérifiez le chemin !");
            return Array.Empty<string>();
        }
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Accès non autorisé au fichier. Vérifiez vos permissions.");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Une erreur s'est produite lors de l'accès au fichier : {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erreur inattendue : {ex.Message}");
        }

        return Array.Empty<string>(); 
}


        static void DevinerMot(string mot)
        {
            List<char> lettres = new List<char>();
            List<char> mauvaisesLettres = new List<char>();
            Console.WriteLine(Ascii.PENDU[0]);
            AfficherMot(mot, lettres);
            Console.WriteLine();

            const int NB_VIES = 6;
            int viesRestantes = NB_VIES;

            while (true)
            {
                char lettre = DemanderLettre();

                if (mot.Contains(lettre))
                {
                    Console.WriteLine($"Le mot contient la lettre {lettre}!\n");

                    if (!lettres.Contains(lettre))
                    {
                        lettres.Add(lettre);
                    }
                    else
                    {
                        Console.WriteLine($"Vous avez déjà deviné la lettre {lettre}.");
                    }

                    if (MotDeviner(mot, lettres))
                    {
                        Console.WriteLine($"Le mot est {mot}, vous avez gagné !");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine($"Le mot ne contient pas la lettre {lettre}...");

                    if (!mauvaisesLettres.Contains(lettre))
                    {
                        mauvaisesLettres.Add(lettre);
                        viesRestantes--;
                    }
                    else
                    {
                        Console.WriteLine($"Vous avez déjà essayé la lettre {lettre}.");
                    }

                    Console.WriteLine($"Vies restantes : {viesRestantes}\n");
                }

                if (viesRestantes == 0)
                {
                    Console.WriteLine(Ascii.PENDU[NB_VIES - viesRestantes]);
                    Console.WriteLine($"Vous avez perdu ! Le mot était {mot}.\n");
                    break;
                }

                AfficherEtat(viesRestantes, NB_VIES, mauvaisesLettres, mot, lettres);
            }
        }

        static void AfficherEtat(int viesRestantes, int NB_VIES, List<char> mauvaisesLettres, string mot, List<char> lettres)
        {
            Console.WriteLine(Ascii.PENDU[NB_VIES - viesRestantes]);
            AfficherMot(mot, lettres);
            Console.WriteLine();
            Console.WriteLine($"Essais : {string.Join(", ", mauvaisesLettres)}");
            Console.WriteLine();
        }

        static char DemanderLettre()
        {
            char lettre;
            string reponse;

            do
            {
                Console.Write("Entrez une lettre (ou tapez 'quit' pour quitter) : ");
                reponse = Console.ReadLine();
                Console.Clear();

                if (reponse.ToLower() == "quit")
                {
                    Console.WriteLine("Vous avez quitté le jeu.");
                    Environment.Exit(0);
                }

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
                    lettre = char.ToUpper(reponse[0]);
                    return lettre;
                }
            } while (true);
        }

        static bool MotDeviner(string mot, List<char> lettres)
        {
            foreach (char c in mot)
            {
                if (!lettres.Contains(c))
                {
                    return false;
                }
            }
            return true;
        }

        static void AfficherMot(string mot, List<char> lettres)
        {
            foreach (char c in mot)
            {
                if (lettres.Contains(char.ToUpper(c)))
                {
                    Console.Write(c + " ");
                }
                else
                {
                    Console.Write("_ ");
                }
            }
            Console.WriteLine();
        }

        static char LireReponseUtilisateur()
        {
            string reponse;

            do
            {
                reponse = Console.ReadLine()?.Trim().ToUpper();

                if (string.IsNullOrEmpty(reponse) || (reponse != "O" && reponse != "N"))
                {
                    Console.WriteLine("Veuillez répondre par 'O' (oui) ou 'N' (non).");
                }
                else
                {
                    return reponse[0];
                }
            } while (true);
        }
    }
}
