using System;


namespace Csharp_masterkurs
{
    internal class StartMenu : Menu
    {
        public override void DisplayMenu()
        {
            Console.WriteLine("Willkommen zur Buchhaltungs-Software");
            Console.WriteLine();
            Console.WriteLine("Was möchtest du tun?");
            Console.WriteLine("--------------------");
            Console.WriteLine("[1] Neues Profil erstellen");
            Console.WriteLine("[2] Profil laden");
            Console.WriteLine();

            InputOption();

        }

        private void InputOption()
        {
            string input;;
            Menu nextMenu;

            while (true)
            {
                Console.WriteLine("Eingabe: ");
                input = Console.ReadLine();
                bool correctInput;


                switch (input)
                { 
                    case "1":
                        nextMenu = new CreateProfileMenu();
                        correctInput = true;
                        break;

                    case "2":
                        nextMenu = new LoadProfileMenu();
                        correctInput = true;
                        break;

                    default:
                        correctInput = false;

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Falsche Eingabe!");
                        Console.ForegroundColor= ConsoleColor.White;

                        break;
                }

                if (correctInput)
                {
                    break;
                }
            }
        }
    }
}
