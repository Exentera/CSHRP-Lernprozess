namespace IT072406.UML
{
    public class Kreis
    {
        #region --ATTRIBUTE--

        private Punkt punkt_a;
        private double radius;

        #endregion

        #region --CONSTRUCTOR--

        public Kreis()
        {
        }
        public Kreis(Punkt punkt_a)
        {
            this.punkt_a = punkt_a;
        }
        public Kreis(Punkt punkt_a, double radius)
        {
            this.punkt_a = punkt_a;
            this.radius = radius;
        }

        #endregion

        #region --GETTER/SETTER--
        
        
        //GET
        public Punkt GetKreis_punkt()
        {
            return punkt_a;
        }
        public double GetKreis_radius()
        {
            return radius;
        }
        
        //SET
        public void SetKreis_punkt(Punkt punkt_a)
        {
            this.punkt_a = punkt_a;
        }
        public void SetKreis_radius(double radius)
        {
            this.radius = radius;
        }

        #endregion

        #region --METHODEN--

        public void RufAnzeiger()
        {
            Anzeige anzeige = new Anzeige();
            anzeige.Flaeche(this);
        }

        #endregion
    }
}