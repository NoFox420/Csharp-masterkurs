namespace Csharp_masterkurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = GetTextInput("Gebe deinen Vornamen ein: ");
            string lastName = GetTextInput("Geben deinen Nachnamen ein: ");

            Console.WriteLine("Hallo {0} {1}", firstName, lastName);
        }

        static string GetTextInput(string message)
        {
            Console.Write(message);
            string userInput = Console.ReadLine();
            return userInput;
        }
        
    }
}