namespace IT072406.UML
{
    public class Punkt
    {
        #region --ATTRIBUTE--

        private double x;
        private double y;

        #endregion
        
        #region --CONSTRUCTOR--

        public Punkt()
        {
        }
        public Punkt(double x)
        {
            this.x = x;
        }
        public Punkt(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        #endregion

        #region --GETTER/SETTER--
        
        // X
        public void SetX(double x)
        {
            this.x = x;
        }
        public double GetX()
        {
            return this.x;
        }
        
        // y
        public void SetY(double y)
        {
            this.y = y;
        }
        public double GetY()
        {
            return this.y;
        }

        #endregion
    }
}