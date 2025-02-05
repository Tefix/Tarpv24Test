using System.Threading.Channels;

namespace coincalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = Math.PI;
            Console.WriteLine(pi);

           
            double coinDiametr = 25.75;
            double earthRadius = 6378000000;
            double aroundearth = 2 * Math.PI * earthRadius;
            Console.WriteLine("maa umberoot " + aroundearth);

            double result = aroundearth / coinDiametr;

            Console.WriteLine("umber maa mahub nii " + 
                "palju kah eurosid" + result);
        }
    }
}
