using System;
using cetheve_orbite.planete;
using cetheve_orbite.objet;
using cetheve_orbite.constante;

namespace cetheve_orbite.simulation
{
    //on défini la classe simulation
    public class Simulation
    {
        private Objet obj;
        private Planete planete ;
        private double angle;
        private double vitesse;

        public Planete Planete
        {
            get { return planete; }
            set { planete = value; }
        }

        public Objet Objet
        {
            get { return obj; }
            set { obj = value; }
        }

        public double Angle
        {
            get { return angle; }
            set { angle = value; }
        }

        public double Vitesse
        {
            get { return vitesse; }
            set { vitesse = value; }
        }

        //calcule et affiche les nouvelles valeurs de l'objet en orbite
        public void startSimulation()
        {
            //on crée une boucle qui tournera tant que l'objet n'est pas entré en contact avec la planete
            while (true)
            {
                //on modifie la direction de l'objet
                Objet.SetGetPos.X += (int) (Vitesse * Math.Cos(Angle));
                Objet.SetGetPos.Y += (int) (Vitesse * Math.Sin(Angle));

                //on appelle les methodes de constante
                Constante constante = new Constante();
                double Distence = constante.Distence(Objet.SetGetPos, Planete.SetGetPos);
                double Gravitation = constante.Gravitation(Objet.SetGetPoids, Planete.SetGetPoids, Distence);

                //on affiche les infos
                Console.WriteLine("Position:\tx: " + Objet.SetGetPos.X + "\n\t\ty: " + Objet.SetGetPos.Y);
                Console.WriteLine("Vitesse:\t" + Vitesse);
                Console.WriteLine("Distence:\t" + Distence + "\n");

                //condition pour vérifier si les deux objets sont en attraction                
                if (Distence < Gravitation) {
                    Angle = Math.Atan2(Planete.SetGetPos.Y, Planete.SetGetPos.X); //l'angle changera selon la tengante de la planete
                    Vitesse *= 0.9; // Attraction de 90%
                }
                //si la objet touche la planete le programme s'arrete
                if (Distence >= Math.Abs(Planete.SetGetDiametre/2))
                {
                    break;
                }
            }
        }
    }
}