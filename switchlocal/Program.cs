namespace switchlocal
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");
            string ch = Console.ReadLine();

            switch (ch)
            {
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("U chose green");
                    break;

                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("U chose red");
                    break;

                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("U chose blue");
                    break;
                
                case "white":
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("U chose white");
                    break;

                case "orange":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("U chose orange");
                    break;


                default:
                    Console.WriteLine("ei ole vokaal e täishäälik");
                    break;
            }
        }
    }
}
