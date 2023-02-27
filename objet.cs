using cetheve_orbite.position;

namespace cetheve_orbite.objet
{
    //on défini la classe objet
    public class Objet
    {
        private Position pos;
        private double Poids;

        public Position SetGetPos
        {
            get { return pos; }
            set { pos = value; }
        }

        public double SetGetPoids
        {
            get { return Poids; }
            set { Poids = value; }
        }
    }
}