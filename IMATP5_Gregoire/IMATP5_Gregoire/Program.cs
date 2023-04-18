using System;

namespace IMATP5_Gregoire
{
    class Program
    {
        static void Main(string[] args)
        {
            int N; // Taille du triangle
            int[,] Triangle; // triangle de pascal
            string stringMatrices; // matrice en string
            string calcul; // le calcul
            bool restart = true; // si on veut recommencer
            string entreeRestart; // pour un if si on veut recommencer
            MethodesDuProjet mesOutils = new MethodesDuProjet();
            while (restart)
            {
                mesOutils.LireReel("Quel sera la taille de votre tableau ?", out N);
                mesOutils.CreationTrianglePascal(N, out Triangle);
                mesOutils.affichageGrille(Triangle, out stringMatrices);
                Console.WriteLine(stringMatrices);
                mesOutils.developpement(N, out calcul, Triangle);
                Console.WriteLine(calcul);
                Console.WriteLine("voulez vous recommencer ? o = oui/reste = non");
                entreeRestart = Console.ReadLine();
                if (entreeRestart != "o")
                {
                    restart = false;
                }

            }

           



        }
        
    }
}
