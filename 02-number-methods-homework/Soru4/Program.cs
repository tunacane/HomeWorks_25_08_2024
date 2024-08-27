namespace Soru4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir sayı giriniz: ");
        double number1 = double.Parse(Console.ReadLine());

        System.Console.WriteLine(Math.Sqrt(number1));
    }
}
