namespace Soru8;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir sayı giriniz: ");

        double number = Convert.ToDouble(Console.ReadLine());

        double numberLog = Math.Log(number);

        System.Console.WriteLine(numberLog);
        
    }
}
