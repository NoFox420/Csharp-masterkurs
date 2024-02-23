namespace Csharp_masterkurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gib ein Text ein: ");
            string text = Console.ReadLine();

            string newText = "";

            foreach (char c in text)
            {
                if(char.IsLetter(c))
                {
                    newText += c;
                } else
                {
                    continue;
                }
            }

            Console.WriteLine(newText);


        }

        
        

        






    }
}