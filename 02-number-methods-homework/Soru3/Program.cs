using System.Xml.XPath;

namespace Soru3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir sayı giriniz: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        int result = Math.Abs(number1);
        System.Console.WriteLine(result);
    }
}
