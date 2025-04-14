using System;
using System.Linq;

namespace IT072406.OOP
{
    public class Zahl
    {
      #region --ATTRIBUTE--

        private int zahl;

      #endregion

      #region --CONSTRUCTOR--
        public Zahl(int zahl)
        {
          this.zahl = zahl;
        }
      #endregion
      
      #region --SETTER/GETTER--
        
      public void SetZahl(int zahl)
        { 
          this.zahl = zahl;
        }
      public int GetZah()
        {
          return this.zahl;
        }

      #endregion
        
      #region --METHODEN--

          public void Spell()  // Gibt ein Zahl in Worte aus
          { 
              
            string[] zh1 = "Null,Ein,Zwei,Drei,Vier,Fünf,Sechs,Sieben,Acht,Neun".Split(',');
            string und = "Und";
            string[] zig = "x,y,Zwanzig,Dreizig,Vierzig,Fünfzig,Sechszig,Siebzig,Achtzig,Neunzig".Split(',');
            string[] zh10 = "Zehn,Elf,Zwölf,Dreizehn,Vierzehn,Fünfzehn,Sechszehn,Siebezehn,Achtzehn,Neuenzehn".Split(',');
            string zh100 = "Hundert";

            int laenge = zahl.ToString().Length;
            string result = zahl + " ist " + laenge + " Zeichen lang" + Environment.NewLine;
            int[] arr = zahl.ToString().Select(ch => ch - '0').ToArray();

            if (laenge == 3)
            {
                if (arr[1] == 0 && arr[2] == 0)
                {
                    result += zh1[arr[0]] + zh100;
                }
                else if (arr[1] == 1 && arr[2] == 0)
                {
                    result += zh1[arr[0]] + zh100 + zh10[arr[1] - 1];
                }
                else if (arr[2] == 0)
                {
                    result += zh1[arr[0]] + zh100 + zig[arr[1]];
                }
                else if (arr[1] == 1)
                {
                    result += zh1[arr[0]] + zh100 + zh10[arr[2]];
                }
                else
                {
                    result += zh1[arr[0]] + zh100 + zh1[arr[2]] + und + zig[arr[1]];
                }
            }
            else if (laenge == 2)
            {
                // Zehnerzahl: arr[0] = Zehner, arr[1] = Einer
                if (arr[1] != 0)
                {
                    result += zh1[arr[1]] + und;
                }
                if (arr[0] == 1)
                {
                    result += zh10[arr[1]];
                }
                else if (arr[0] >= 2)
                {
                    result += zig[arr[0]];
                }
            }
            else if (laenge == 1)
            {
                // Einfache Zahl: Nur eine Ziffer
                result += zh1[arr[0]];
                if (arr[0] == 1)
                {
                    result += "s";
                }
            }
            Console.WriteLine(result);
          }

      #endregion
    }//end class
}