namespace IT072406.OOP
{
    public class Auto
    {
        // ATTRIBUTE / EIGENSCHAFTEN
        public string hersteller;
        public string modell;
        public float kilometer;
        public string farbe;
        public int aktuelleGeschwindigkeit;
        
        // METHODEN
        public void Fahren()
        {
            aktuelleGeschwindigkeit += 10;
        }

        public void Bremsen()
        {
            aktuelleGeschwindigkeit -= 10;

            if (aktuelleGeschwindigkeit < 0)
                aktuelleGeschwindigkeit = 0;
        }
    }
}