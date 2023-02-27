using cetheve_orbite.objet;

namespace cetheve_orbite.planete
{
	//on défini la classe Planete, fille de la classe Objet
	public class Planete : Objet
	{
		private double Diametre;

		public double SetGetDiametre
		{
			get { return Diametre; }
			set { Diametre = value; }
		}
	}
}