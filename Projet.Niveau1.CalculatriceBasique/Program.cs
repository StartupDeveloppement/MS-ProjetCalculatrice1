using System;

namespace Projet.Niveau1.CalculatriceBasique
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Affichage.Afficher("Bonjour !");
            TypeOperation();
        }

        private static void TypeOperation()
        {
            Affichage.Afficher("Quelle type d'opération souhaitez vous faire :");
            Affichage.Afficher("1.Addition");
            Affichage.Afficher("2.Soustraction");
            Affichage.Afficher("3.Multiplication");
            Affichage.Afficher("4.Division");
            double saisie1=0.0;
            bool saisieClavier = double.TryParse (Console.ReadLine(), out saisie1);

            if (saisie1 == 1)
            {
                Affichage.AfficherSansRetourLigne("Premier nombre :");
                double saisie2 = 0.0;
                bool premierChiffre = double.TryParse(Console.ReadLine(), out saisie2);
                Affichage.AfficherSansRetourLigne("Second nombre :");
                double saisie3 = 0.0;
                bool secondChiffre = double.TryParse(Console.ReadLine(), out saisie3);

                var calcul = new Calcul(saisie2, saisie3);
                var resultat = calcul.addition();

                Affichage.Afficher("Le résultat est : " + resultat);
                TypeOperation();
            }
            else if (saisie1 == 2)
            {
                Affichage.AfficherSansRetourLigne("Premier nombre :");
                double saisie2 = 0.0;
                bool premierChiffre = double.TryParse(Console.ReadLine(), out saisie2);
                Affichage.AfficherSansRetourLigne("Second nombre :");
                double saisie3 = 0.0;
                bool secondChiffre = double.TryParse(Console.ReadLine(), out saisie3);

                var calcul = new Calcul(saisie2, saisie3);
                var resultat = calcul.soustraction();

                Affichage.Afficher("Le résultat est : " + resultat);
                TypeOperation();
            }
            else if (saisie1 == 3)
            {
                Affichage.AfficherSansRetourLigne("Premier nombre :");
                double saisie2 = 0.0;
                bool premierChiffre = double.TryParse(Console.ReadLine(), out saisie2);
                Affichage.AfficherSansRetourLigne("Second nombre :");
                double saisie3 = 0.0;
                bool secondChiffre = double.TryParse(Console.ReadLine(), out saisie3);

                var calcul = new Calcul(saisie2, saisie3);
                var resultat = calcul.multiplication();

                Affichage.Afficher("Le résultat est : " + resultat);
                TypeOperation();
            }
            else if (saisie1 == 4)
            {
                Affichage.AfficherSansRetourLigne("Premier nombre :");
                double saisie2 = 0.0;
                bool premierChiffre = double.TryParse(Console.ReadLine(), out saisie2);
                Affichage.AfficherSansRetourLigne("Second nombre :");
                double saisie3 = 0.0;
                bool secondChiffre = double.TryParse(Console.ReadLine(), out saisie3);

                var calcul = new Calcul(saisie2, saisie3);
                var resultat = calcul.division();

                Affichage.Afficher("Le résultat est : " + resultat);
                TypeOperation();
            }
            else
            {
                Affichage.Afficher("Mauvaise saisie");
                TypeOperation();
            }
        }
    }
}