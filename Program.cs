namespace Csharp_masterkurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gib ein Wort ein: ");
            string text = Console.ReadLine();

            if (isPalindrome(text))
            {
                Console.WriteLine(text + " ist ein Palindrom");

            }
            else
            {
                Console.WriteLine(text + " is kein Palindrom");
            }
        }

            static bool isPalindrome(string text) {
                
                string reversed = "";

                for (int i = text.Length-1; i >= 0; i--)
                {
                    reversed += text[i];
                
                }

                return reversed.ToLower() == text.ToLower();
            }
        

        






    }
}