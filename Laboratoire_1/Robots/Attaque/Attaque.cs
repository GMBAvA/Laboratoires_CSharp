namespace robot
{
    class Attaque
    {
        public int valeur;
        public string nom;
        public Attaque(int valeur, string nom)
        {
            this.valeur = valeur;
            this.nom = nom;
        }
        public int Valeur
        {
            get { return valeur; }
        }

        public string Nom
        {
            get { return nom; }
        }

        public override string ToString()
        {
            return Valeur.ToString();
        }
    }
}
