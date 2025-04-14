namespace IT072406.UML
{
    public class Linie
    {
        #region --ATTRIBUTE--

        private Punkt punkt_a;
        private Punkt punkt_b;

        #endregion
        
        #region --CONSTRUCKTOR--

        public Linie()
        {
        }
        public Linie(Punkt punkt_a)
        {
            this.punkt_a = punkt_a;
        }
        public Linie(Punkt punkt_a, Punkt punkt_b)
        {
            this.punkt_a = punkt_a;
            this.punkt_b = punkt_b;
        }

        #endregion
        
        #region --GETTER/SETTER--
        
        
        //GET
        public Punkt GetPunkt_a()
        {
            return this.punkt_a;
        }
        public Punkt GetPunkt_b()
        {
            return this.punkt_b;
        }
        //SET
        public void SetPunkt_a(Punkt punkt_a)
        {
            this.punkt_a = punkt_a;
        }
        public void SetPunkt_b(Punkt punkt_b)
        {
            this.punkt_b = punkt_b;
        }


        #endregion

        #region --METHODEN-- 
        public void RufeAnzeige()
        {
            // Obj von An zeige erstelklen
            // richtige methode 
            // this

            Anzeige anzeige = new Anzeige();
            anzeige.Laenge(this);
        }


        #endregion
    }
}