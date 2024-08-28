namespace Soru10;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Birinci sayıyı giriniz: ");
        decimal num1 = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("İkinci sayıyı giriniz: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        if (num2>0)
        {
            decimal result = Math.Round(num1, num2);
            System.Console.WriteLine(result);
        }
        else{
            System.Console.WriteLine("Geçersiz sayı girdiniz!!");
        }
    }
}
