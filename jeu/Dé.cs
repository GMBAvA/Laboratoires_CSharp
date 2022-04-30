using System;

namespace jeu
{
    internal class Dé
    {
        private int nbFaces;
        private Random random;
        public Dé()
        {
            nbFaces = 6;
            random = new Random();
            int[] valeur = { 1, 2, 3, 4, 5, 6 };
        }

        public int TournerLesDes()
        {
            int res = random.Next(1, 7);
            return res;
        }
    }
}
