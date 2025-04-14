namespace IT072406.Aufgaben.Aufgabe_7._2
{
    public class Main_7_2
    {
        public static void Run()
        {
            Wal tim = new Wal("Tim", 1800);
            Delfin flippa = new Delfin("Flippa", 1800);
            Elefant ben = new Elefant("Ben", 25);
            Nashorn trockenhorn = new Nashorn("Marta",35);
            
            
            tim.Steckbrief();
            flippa.Steckbrief();
            ben.Steckbrief();
            trockenhorn.Steckbrief();
            
        }
    }
}