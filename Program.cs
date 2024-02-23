namespace Csharp_masterkurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IMPLIZITE KONVERTIERUNG (AUTOMATISCH)
            float float1 = 123.32F;
            double double1 = float1;


            //EXPLIZITE KONVERTIERUNG (MANUELL)
            double double2 = 123.1;
            float float2 = (float)double2;

            //HILFSKLASSEN
            float2 = Convert.ToSingle(double2);
                
        }

    }
}