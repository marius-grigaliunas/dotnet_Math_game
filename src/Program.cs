namespace Math_Game.src
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowWidth = 100;

            Console.WriteLine("Math Game");

            Console.WriteLine("To exit the app enter   exit");

            bool endApp = false;

            while (!endApp)
            {
                Console.WriteLine("Your input:");
                string input = Console.ReadLine() ?? "";

                Input.CheckInput(input, out endApp, out string returnMessage);
                Console.WriteLine(returnMessage);
            }
        }
    }
}