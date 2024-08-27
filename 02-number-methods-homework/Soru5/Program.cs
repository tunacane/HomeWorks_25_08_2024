namespace Soru5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Birinci sayı giriniz: ");
        int number1 = int.Parse(Console.ReadLine());

        Console.WriteLine("İkinci sayıyı giriniz: ");
        int number2 = int.Parse(Console.ReadLine());

        System.Console.WriteLine((int)Math.Pow(number1, number2));
    }
}
