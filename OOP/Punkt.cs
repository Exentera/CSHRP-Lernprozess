using System;

namespace IT072406.OOP
{
    public class Punkt
    {
        public int x;
        public int y;
        
        public Punkt()
        {
        }
        
        public Punkt(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Punkt(Punkt p)
        {
            this.x = p.x;
            this.y = p.y;
        }

        public float abstand()
        {
            double result = Math.Sqrt(x * x + y * y);
            return (float)result;
        }
    }//end class
}