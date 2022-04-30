namespace jeu
{
    public class Gobelet
    {
        private Dé de1;
        private Dé de2;
        public Gobelet()
        {
            de1 = new Dé();
            de2 = new Dé();
        }

        public int LancerGobelet()
        {
            return de1.TournerLesDes() + de2.TournerLesDes();
        }
    }
}
