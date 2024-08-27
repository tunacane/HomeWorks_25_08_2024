namespace Soru6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir sayı giriniz");
        double number1 = Convert.ToDouble(Console.ReadLine());

        double radyan = number1 *(Math.PI / 180);

        System.Console.WriteLine($"{number1} sayısının sinüs cinsinden değeri {radyan}'dır.");
    }
}
