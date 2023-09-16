namespace Csharp_masterkurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Logische operatoren:
            //&& UND , || ODER , ! NICHT

            Console.WriteLine("Bitte gib dein Gewicht in KG an: ");
            int weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bitte gib deine Größe in Metern an: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double calcBMI = BMI(weight, height);

            if (calcBMI <= 18.4)
            {
                Console.WriteLine("Du hast Untergewicht!");
            }
            else if (calcBMI >=18.5 && calcBMI <= 24.9)
            {
                Console.WriteLine("Du hast Normalgewicht!");
            }
            else if (calcBMI >=25 &&  calcBMI <= 29.9)
            {
                Console.WriteLine("Du hast Übergewicht!");
            }
            else if (calcBMI >= 30 && calcBMI <= 34.9)
            {
                Console.WriteLine("Du hast Adipositas Grad 1 !");
            }
            else if (calcBMI >= 35 && calcBMI <= 39.9)
            {
                Console.WriteLine("Du hast Adipositas Grad 2!");
            }
            else if (calcBMI >= 40)
            {
                Console.WriteLine("Du hast Adipositas Grad 3!");
            }

        }

       static int userBodyweight (string getWeight) 
        {
            int weight = Convert.ToInt32(Console.ReadLine());
            return weight;
        }
        
        static double userHeight (string getHeight) 
        {
            double height = Convert.ToDouble(Console.ReadLine());
            return height;
        
        }

        static double BMI (int weight, double height) 
        {
            double bmi = weight / (height * height);
            Console.WriteLine("Dein BMI ist: {0}", bmi);
            return bmi;
            
        }

        
    }
}