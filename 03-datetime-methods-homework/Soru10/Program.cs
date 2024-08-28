using System.Net.Http.Headers;

namespace Soru10;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir tarih giriniz: ");

        string time = Console.ReadLine();

        DateTime date = Convert.ToDateTime(time);

        System.Console.WriteLine(date.ToString("HH"));

        // System.Console.WriteLine(now.ToString("HH:mm:ss"));


    }
}
