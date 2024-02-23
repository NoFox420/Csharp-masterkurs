namespace Csharp_masterkurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        static void MainMenu()
        {
            while(true) { 

                Console.WriteLine("### HANGMAN ###");
                Console.WriteLine("###############");
                Console.WriteLine();
                Console.WriteLine("AKTION:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[1] PLAY");
                Console.WriteLine("[2] END GAME");
                Console.ResetColor();
                int action = Convert.ToInt32(Console.ReadLine());
                bool end = false;

                switch (action)
                {
                    case 1:
                        StartGame();
                            break;

                    case 2:
                        end = true;
                        break;
                }

                if (end) { 
                    break; 
                }

                Console.Clear();
            }

            static void StartGame()
            {
                string[] words = new string[]
                {
                    "Apfelkuchen",
                    "Gemüsesuppe",
                    "Kraftfahrzeug",
                    "Lastwagen",
                    "Videospiel",
                    "Alarmanlage",
                    "Vollkornbrot"
                };

                Random rnd = new Random();
                int index = rnd.Next(0, words.Length);
                string word = words[index].ToLower();
                GameLoop(word);
            }

            static void GameLoop(string word)
            {
                int lives = 10;
                string hiddenWord = "";

                for (int i = 0; i < word.Length; i++)
                {
                    hiddenWord += "_";
                }

                while(true) {
                    Console.Clear();
                    Console.WriteLine("Gesuchtes Wort: " + hiddenWord);
                    Console.Write("Noch übrige Versuche: ");

                    for (int i = 0; i < lives; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        if (lives <= 1)
                        {
                            Console.Write("Letzter Versuch!");
                        } else
                        {
                            Console.Write("X");
                        }
                        Console.ResetColor();
                    }

                    Console.WriteLine();
                    Console.WriteLine("Buchstabe: ");
                    char letter = Convert.ToChar(Console.ReadLine().ToLower());

                    bool foundLetterInWord = false;

                    for (int i = 0;i < word.Length;i++)
                    {
                        if (word[i] == letter)
                        {
                            foundLetterInWord = true;
                            break;
                        }
                    }

                    string tempHiddenWord = hiddenWord;
                    hiddenWord = "";

                    if(foundLetterInWord)
                    {
                        for (int i = 0; i < word.Length;i++)
                        {
                            if (word[i] == letter)
                            {
                                hiddenWord += letter;
                            }
                            else if (tempHiddenWord[i] != '_')
                            {
                                hiddenWord += tempHiddenWord[i];
                            }
                            else
                            {
                                hiddenWord += '_';
                            }
                        }

                        if (hiddenWord == word)
                        {
                            Console.Clear();
                            Console.ForegroundColor= ConsoleColor.Green;
                            Console.WriteLine("GEWONNEN!");
                            Console.WriteLine("Das Wort war: " + word);
                            Console.ResetColor();
                            Console.ReadKey();
                            break;
                        }
                    }
                    else
                    {
                        hiddenWord = tempHiddenWord;

                        if (lives > 0)
                        {
                            lives -= 1;
                        }
                        else
                        {
                            Console.Clear();
                            Console.ForegroundColor= ConsoleColor.Red;
                            Console.WriteLine("GAME OVER!");
                            Console.ResetColor();
                            Console.WriteLine("Das gesuchte Wort war: " + word);
                            Console.ReadKey();
                            break;
                        }
                    }
                }
            }
        }

        
        

        






    }
}