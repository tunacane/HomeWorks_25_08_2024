namespace Soru1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir sayı giriniz: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        if (num1 >0)
        {
            System.Console.WriteLine($"{num1} pozitif  bir sayıdır.");
        }
        else if (num1 <0)
        {
            System.Console.WriteLine($"{num1} negatif bir sayıdır.");
        }
        else
        {
            System.Console.WriteLine($"{num1} sayısı 0'a eşittir");
        }
    }
}
