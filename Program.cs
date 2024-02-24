namespace Csharp_masterkurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hund hund1 = new Hund(4, "Pluto", "Peter Müller");
            Console.WriteLine(hund1.Herrchen);
        }

    }

    class Hund
    {
        //Eigenschaften
        public int Alter { get; set; }
        public string Name { get; set; }
        public string Herrchen { get; set; }

        //private int alter

        //Konstruktor
        public Hund(int alter, string name, string herrchen) {

            //Eigenschaften werden Parameter zugewiesen
            Alter = alter;
            Name = name;
            Herrchen = herrchen;
            
            //bei privaten variablen, ignoriert den von aussen kommenden Parameter
            //this.alter = alter;

        }
    }    
}