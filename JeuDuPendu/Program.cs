using System;

namespace JeuDuPendu
{
    class Program
    {
        static void Main(string[] args)
        {
            string mot = "Arachide";
            
            AfficherMot(mot);
            //DevinerMot();

        }

        static void AfficherMot(string mot)
        {         
            string motAffiché = ""; 

            for(int i=1;i<=mot.Length;i++)
            {
                motAffiché = motAffiché += "_ ";
            }
            Console.WriteLine(motAffiché);
        }
    }
}