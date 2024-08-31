using Microsoft.VisualBasic;

namespace Soru9;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir sayı giriniz: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Bir sayı daha giriniz: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("İşlem giriniz: ");

        string islem = Console.ReadLine();

        int toplam = num1 + num2;
        int fark = num1 - num2;
        int carpim = num1 * num2;
        int bolme = num1 / num2;

        if (islem == "+")
        {
            System.Console.WriteLine($"İki sayının toplamı: {toplam}");
        }
        else if (islem == "-")
        {
            System.Console.WriteLine($"İki sayının farkı: {fark}");
        }
       else  if (islem == "*")
        {
            System.Console.WriteLine($"İki sayının çarpımı: {carpim}");
        }
        else
        {
            System.Console.WriteLine($"İki sayının oranı: {bolme}");
        }


    }
}
