using System;
using System.Dynamic;

namespace IT072406.Grundlagen
{
    public class bubblesort
    {
        public static void run()
        {
            int[] werte = new[] { 12, 65, 858, 46, 565, 4, 13, 1, 8, 2, 32, 45 };

            int temp;
            int i, j;

            for (i = werte.Length - 2; i >= 0; i--)
            {
                for (j = 0;j<=i; j++)
                {
                    if (werte[j] > werte[j + 1])
                    {
                        temp = werte[j];
                        werte[j] = werte[j + 1];
                        werte[j + 1] = temp;
                    }
                }
            }

            for (int k = 0; k < werte.Length; k++)
            {
                Console.Write(" | "+werte[k]);
            }
            Console.Write(" | ");
        }

        
        
        
        public static void run1()
        {
            int[] werte = new[] { 12, 65, 858, 46, 565, 4, 13, 1, 8, 2, 32, 45 };

            int temp;
            int i, j;
            int anz = werte.Length;
            bool tausch = false;

            do
            {
                tausch = false;
                for (i = 0;i < anz-1; i++)
                {
                    if (werte[i] > werte[i + 1])
                    {
                        temp = werte[i];
                        werte[i] = werte[i + 1];
                        werte[i + 1] = temp;
                        tausch = true;
                    }
                }
            } while (tausch==true);
            
            for (int k = 0; k < werte.Length; k++)
            {
                Console.Write(" | "+werte[k]);
            }
            Console.Write(" | ");
        }
    }
}