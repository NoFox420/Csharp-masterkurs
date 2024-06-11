using System;


namespace Csharp_masterkurs
{
    [Serializable]
    abstract class Menu
    {
        public Menu()
        {
            Console.Clear();
            DisplayMenu();
        }

        public abstract void DisplayMenu();
    }
}
