namespace Csharp_masterkurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayHello("Jan", 30);
        }
        //Methoden werden in klassen definiert
        //static methoden werden nicht auf objekten aufgerufen
        //void definiert den rückgabewert

        static void SayHello(string name, int age)
        {
            Console.WriteLine("Hallo {0}, du bist {1} Jahre alt!", name, age);
        }
    }
}