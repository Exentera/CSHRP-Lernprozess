using System;
using System.CodeDom;

namespace IT072406.UML

{
   public class Aufgabe3_3
   {

      public static void run()
      {
         Punkt linieP1 = new Punkt(7,1);
         Punkt linieP2 = new Punkt(12,5);

         Linie linie = new Linie(linieP1, linieP2);
         linie.RufeAnzeige();


         Punkt kreis_P1 = new Punkt(9,7);
         Kreis kreis_1 = new Kreis(kreis_P1,2);
         kreis_1.RufAnzeiger();


         Punkt rechteck_P1 = new Punkt(3,6);
         Punkt rechteck_P2 = new Punkt(6,6);
         Punkt rechteck_P3 = new Punkt(6,4);
         Punkt rechteck_P4 = new Punkt(3,4);

        
         
         Rechteck rechteck_001 = new Rechteck(rechteck_P1, rechteck_P2, rechteck_P3, rechteck_P4);
         rechteck_001.RufAnzeiger();
         
      }
      
      
   }
    
    
}