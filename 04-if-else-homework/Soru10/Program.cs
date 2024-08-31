namespace Soru10;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir sayı giriniz: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        if (IsPrime(num1))

        {
            Console.WriteLine($"{num1} bir asal sayıdır.");
        }
        else
        {
            Console.WriteLine($"{num1} bir asal sayı değildir.");

        }
}
}