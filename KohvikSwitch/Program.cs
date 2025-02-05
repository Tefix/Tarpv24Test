namespace KohvikSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fantaasia kohvik!");

            Console.WriteLine("\nMenüü (kohvi valik)\n\n");
            Console.WriteLine("1. Väike tass"); //1.5
            Console.WriteLine("2. Keskmine tass"); //2.5
            Console.WriteLine("3. Suur tass"); //3

            Console.WriteLine("\nPalun tee valik numbriga: ");
            string number = Console.ReadLine();

            switch (number)
            {
                case "1":
                    Console.WriteLine("sa valid  Väike tass");
                    break;
                    case "2":
                    Console.WriteLine("sa valid Keskmine tass");
                    break;
                    case "3":
                    Console.WriteLine(" sa valid Suur tass");
                    break;
            }
        }
    }
}
