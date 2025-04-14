namespace IT072406.UML
{
    public class Rechteck
    {
        #region --ATTRIBUTE--

        private Punkt punkt_a;
        private Punkt punkt_b;
        private Punkt punkt_c;
        private Punkt punkt_d;

        #endregion

        #region --CONSTRUCTOR--

        public Rechteck()
        {
            
        }
        /*
        public Rechteck(Punkt punkt_a, Punkt punkt_b)
        {
            this.punkt_a = punkt_a;
        }
        public Rechteck(Punkt punkt_a, Punkt punkt_b)
        {
            this.punkt_a = punkt_a;
            this.punkt_b = punkt_b;
        }
        */
        public Rechteck(Punkt punkt_a, Punkt punkt_b, Punkt punkt_c)
        {
            this.punkt_a = punkt_a;
            this.punkt_b = punkt_b;
            this.punkt_c = punkt_c;
        }
        public Rechteck(Punkt punkt_a, Punkt punkt_b, Punkt punkt_c, Punkt punkt_d)
        {

            this.punkt_a = punkt_a;
            this.punkt_b = punkt_b;
            this.punkt_c = punkt_c;
            this.punkt_d = punkt_d;

        }


        #endregion

        #region --GETTER/SETTER--

        public Punkt GetPunkt_a()
        {
            return punkt_a;
        }

        public Punkt GetPunkt_b()
        {
            return punkt_b;
        }
        
        public Punkt GetPunkt_c()
        {
            return punkt_c;
        }

        public Punkt GetPunkt_d()
        {
            return punkt_d;
        }

        public void SetPunkt_c(Punkt punkt_c)
        {
            this.punkt_c = punkt_c;
        }
        public void SetPunkt_d(Punkt punkt_d)
        {
            this.punkt_d = punkt_d;
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