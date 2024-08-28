namespace Soru5;

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

        
        if ((num1 + num2) > num3 && (num1 + num3) > num2 && (num2 + num3) > num1)
        {
            System.Console.WriteLine("Üçgen elde edilebilir.");
        }
        else
        {
            System.Console.WriteLine("Üçgen elde edilemez");
        }
    }
}
