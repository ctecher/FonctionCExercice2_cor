/**
 * Exercice 2 : ajout de la fonction saisie dans un programme
 * author : CT
 * date : 11/2021
 */
using System;

namespace FonctionCExercice2
{
    internal class Program
    {
        /// <summary>
        /// Saisie de L ou E avec contrôle de saisie
        /// </summary>
        /// <param name="message">Message à afficher</param>
        /// <param name="valeur1">1er caractère accepté</param>
        /// <param name="valeur2">2e caractère accepté</param>
        /// <returns>lettre saisie</returns>
        static char saisie(string message, char valeur1, char valeur2)
        {
            char reponse;
            do
            {
                Console.WriteLine();
                Console.Write(message);
                reponse = Console.ReadKey().KeyChar;
            } while (reponse != valeur1 && reponse != valeur2);
            return reponse;
        }

        static void Main(string[] args)
        {
            // Déclaration
            char statut;

            // demande su statut
            statut = saisie("Etes-vous lycéen(ne) ou étudiant(e) ? (L/E) ", 'L', 'E');
            
            // Affichage du message personnalisé
            Console.WriteLine();
            if (statut == 'L')
            {
                Console.WriteLine("Bonjour lycée(ne).");
            }
            else
            {
                Console.WriteLine("Bonjour étudiant(e)");
            }
            Console.ReadLine();
        }
    }
}
