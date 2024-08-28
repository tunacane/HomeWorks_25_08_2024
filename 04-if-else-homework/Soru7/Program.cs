namespace Soru7;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Birinci sayıyı giriniz: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("İkinci sayıyı giriniz: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Üçüncü sayıyı giriniz: ");
        int num3 = Convert.ToInt32(Console.ReadLine());

        int enBuyuk;

        if (num1 > num2 && num1 > num3)
        {
            System.Console.WriteLine($"En büyük sayı: {num1}");
        }
        else if (num2 > num1 && num2 > num3)
        {
            System.Console.WriteLine($"En büyük sayı: {num2}");
        }
        else{
            System.Console.WriteLine($"En büyük sayı: {num3}");
        }
    }
}
