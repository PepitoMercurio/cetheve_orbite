using cetheve_orbite.position;

namespace cetheve_orbite.constante
{
    //on défini la classe Constante
    public class Constante
    {
        //on definie la contente de gravite
        private const double Gravite = 6.67408e-11;

        public double Distence(Position Objet1, Position Objet2)
        {
            //On calcule la distence entre la planete et l'objet
            double DistenceX = Objet2.X - Objet1.X;
            double DistenceY = Objet2.Y - Objet1.Y;
            double Distence = Math.Sqrt(DistenceX * DistenceX + DistenceY * DistenceY);
            return Distence;
        }

        public double Gravitation(double obj1Poids, double obj2Poids, double distance)
        {
            //On calcue la gravitation avec la formule (Gravitation * masse(A) * masse(b) / distence²)
            return (Gravite * obj1Poids * obj2Poids) / (distance * distance);
        }
    }
}