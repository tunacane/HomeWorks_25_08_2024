namespace Soru7;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir sayı giriniz: ");

        double derece = Convert.ToDouble(Console.ReadLine());

        double radyan = derece* (Math.PI / 180);

        System.Console.WriteLine($"{derece}'nin radyan cinsinde değeri {radyan}'dır.");
    }
}
