namespace IT072406.OOP.Kaempfer
{
    public class main
    {
        public static void run()
        {
            krieger heman = new krieger();
            magier guenter = new magier();
            jaeger bert = new jaeger();

            kaempfer[] gruppe = new kaempfer[3];
            gruppe[0] = heman;
            gruppe[1] = guenter;
            gruppe[2] = bert;

            foreach (kaempfer k in gruppe)
            {
                k.Angriff();
            }

        }
    }
}