using System.Runtime.CompilerServices;

namespace IT072406.OOP
{
    public class Person1
    {
        protected string vorname;
        
        public void SetVorname(string vorname)
        {
            this.vorname = vorname;
        }

        public string Getvorname()
        {
            return vorname;
        }
    }

}