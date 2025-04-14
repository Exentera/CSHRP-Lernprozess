using System;

namespace IT072406.OOP
{
    public class VererbungsTester1
    {
        public static void run()
        {
            Kunde1 kunde = new Kunde1();
            kunde.SetVorname("Kunde");

            Mitarbeiter1 mitarbeiter = new Mitarbeiter1();
            mitarbeiter.SetVorname("Mitarbeiter");
            mitarbeiter.mitarbeiterNummer = 1;


            Object test = new Object();
            
            ObjektTester1 objektTester = new ObjektTester1();
        }
    }
}