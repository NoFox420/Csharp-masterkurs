namespace Csharp_masterkurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto kombi = new Auto();
            kombi.Hersteller = "Audi";
            Console.WriteLine(kombi.Hersteller);
            kombi.Türen = 0;
            Console.WriteLine(kombi.Türen);
        
        }

    }

    class Auto
    {
        //Eigenschaften
        public string Hersteller { get; set; }

        //klassenintern genutzte variable
        private int anzahlTüren;
        public int Türen
        {
            //liest klasseninterne variable
            get
            {
                return anzahlTüren;
            }
            //überschreibt klasseninterne variable
            set
            {
                //extra implementierte logik
                if (value < 2)
                {
                    anzahlTüren = 2;
                } 
                else
                {
                    anzahlTüren = value;
                }
                
            }
        }
    }
}