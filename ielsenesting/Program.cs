namespace ielsenesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number Control!");

            int number = 190;

            if (number > 189)
            {
                Console.WriteLine("number is bigger");

                if (number > 190 && number <= 200)
                {
                    Console.WriteLine("number is between 190 to 200");
                }
                else
                {
                    Console.WriteLine("number is bigger than 200");
                }
            }
            else {
                Console.WriteLine("number is smaller");
            }

        }
    }
}
