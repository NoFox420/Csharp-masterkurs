namespace Csharp_masterkurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

                Console.Write("Gib die Breite ein: ");
                int width = Convert.ToInt32(Console.ReadLine());

                Console.Write("Gib die Höhe ein: ");
                int height = Convert.ToInt32(Console.ReadLine());

                DrawRectangle(width, height);



        }

        static void DrawRectangle(int width, int height)
        {
            for (int i = 0; i < height; i++)
            {
                
                for (int j = 0; j < width; j++)
                {
                    Console.Write("#");
                }

                Console.WriteLine("#");

            }
        }






    }
}