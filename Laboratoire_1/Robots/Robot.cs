using combat;
namespace robot
{
    class Robot
    {
        public Protection protection;
        public Vitesse vitesse;
        public Attaque attaque;

        public string nom;
        public int type;
        public Robot(string nom , int type )
        {
            this.nom = nom;
            this.type = type;
        }


        public Protection Protection
        {
            get { return protection; }
            set { protection = value; }
        }

        public Vitesse Vitesse
        {
            get { return vitesse; }
            set { vitesse = value; }
        }

        public Attaque Attaque
        {

            get { return attaque; }
            set { attaque = value; }
        }

        public Robot Infos
        {
            get { return this; }
        }

        public string Nom
        {
            get { return nom; }
        }

        public override string ToString()
        {
            return "" + nom + " possède " + Attaque + " points d'attaque, " + Vitesse + " de vitesse et " + Protection + " points de défense.";
        }
    }
}