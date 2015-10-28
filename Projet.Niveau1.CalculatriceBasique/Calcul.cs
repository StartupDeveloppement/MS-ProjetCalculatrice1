namespace Projet.Niveau1.CalculatriceBasique
{
    public class Calcul
    {
        private double premierChiffre;
        private double secondChiffre;

        public Calcul(double premierChiffre, double secondChiffre)
        {
            this.premierChiffre = premierChiffre;
            this.secondChiffre = secondChiffre;
        }

        public double addition()
        {
            return premierChiffre + secondChiffre;
        }

        public double soustraction()
        {
            return premierChiffre - secondChiffre;
        }

        public double multiplication()
        {
            return premierChiffre * secondChiffre;
        }

        public double division()
        {
            return premierChiffre / secondChiffre;
        }
    }
}