using System;
using System.Collections.Generic;
using System.Text;

namespace IMATP5_Gregoire
{
    public struct MethodesDuProjet
    {
        /// <summary>
        /// permet la creation du triangle pascal
        /// </summary>
        /// <param name="N">dimension du triangle</param>
        /// <param name="Triangle">le triangle construis</param>
        public void CreationTrianglePascal(int N, out int[,] Triangle)
        {
            int tailleMatrices = N + 1;
            Triangle = new int[tailleMatrices, tailleMatrices];
            for (int i = 0; i < tailleMatrices; i++)
            {
                for (int y = 0; y < tailleMatrices; y++)
                {
                    Triangle[i, y] = 0;
                }
            }
            for (int i = 0; i < tailleMatrices; i++)
            {
                Triangle[i, 0] = 1;
            }
            for (int i = 1; i < tailleMatrices; i++)
            {
                for (int y = 1; y < tailleMatrices; y++)
                {
                    if (Triangle[i - 1, y - 1] != 0)
                    {
                        Triangle[i, y] = Triangle[i - 1, y - 1] + Triangle[i - 1, y];
                    }
                }
            }
        }
        /// <summary>
        /// permet de faire le calcul
        /// </summary>
        /// <param name="N">dimensions du triangle</param>
        /// <param name="Calcul">contient le calcul final</param>
        /// <param name="Triangle">contient le triangle a transformer en calcul</param>
        public void developpement(int N, out string Calcul, int[,] Triangle)
        {
            int tailleMatrices = N + 1;
            Calcul = "";
            int x1 = 0;
            int x2 = N;
            for (int i = 0; i < tailleMatrices; i++)
            {
                Calcul += Triangle[N, i] + " * a ^ " + x2 + " * b ^ " + x1 + " + ";
                x1 += 1;
                x2 -= 1;
            }



        }
        /// <summary>
        /// permet d'afficher la grille en resortant un string
        /// </summary>
        /// <param name="Triangle">matrices a transformer en string</param>
        /// <param name="stringMatrices">ressort la matrices en string</param>
        public void affichageGrille(int[,] Triangle, out string stringMatrices)
        {
            stringMatrices = "";
            for (int i = 0; i < Triangle.GetLength(0); i++)
            {
                for (int y = 0; y < Triangle.GetLength(1); y++)
                {
                    if (Triangle[i, y] != 0)
                    {
                        stringMatrices += String.Format("{0,6}",Triangle[i, y] + "|");
                    }



                }
                stringMatrices += "\n";
            }
        }
        /// <summary>
        /// permet de verifier une entree d'utilisateur
        /// </summary>
        /// <param name="question">la question a poser</param>
        /// <param name="n">l'entree en int</param>
        public void LireReel(string question, out int n)
        {
            string nUser;
            Console.Write(question);
            nUser = Console.ReadLine();
            while (!int.TryParse(nUser, out n))
            {
                Console.WriteLine("Attention ! vous devez taper un nombre réel !");
                nUser = Console.ReadLine();
            }
        }









    }
}
