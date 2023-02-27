using System;
using cetheve_orbite.simulation;
using cetheve_orbite.planete;
using cetheve_orbite.objet;
using cetheve_orbite.position;

namespace TestCSharp
{
    //La classe programme servira à instencier les valeurs de chaque éléments puis de démarer la simulation
    class Program
    {
        static void Main(string[] args)
        {
            
            //attribue des valeur à l'objet Objet
            Position objPos = new Position();
            objPos.X = 0;
            objPos.Y = 0;

            Objet obj = new Objet();
            obj.SetGetPoids = 10;
            obj.SetGetPos = objPos;


            //attribue des valeur à l'objet Planete
            Position planetePos = new Position();
            planetePos.X = 500;
            planetePos.Y = 100;

            Planete plan = new Planete();
            plan.SetGetDiametre = 8000;
            plan.SetGetPoids = 50;
            plan.SetGetPos = planetePos;


            //attribue des valeur à l'objet Simuation
            Simulation sim = new Simulation();
            sim.Objet = obj;
            sim.Planete = plan;
            sim.Angle = -5;
            sim.Vitesse = 2;


            //lance la simulation
            sim.startSimulation();
        }
    }
}
