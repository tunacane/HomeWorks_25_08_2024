using System.Xml.XPath;

namespace Soru1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir tarih giriniz");

        DateTime date = Convert.ToDateTime(Console.ReadLine());



        System.Console.WriteLine($"Bugün günlerden {date.DayOfWeek.ToString()}.");
    }
}
