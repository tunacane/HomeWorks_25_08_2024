namespace Soru9_;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Birinci sayıyı giriniz: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("İkinci sayıyı giriniz: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        string result;

        if (num1 > num2)
        {
            result = "birinci sayı büyüktür.";
        }
        else if (num2 > num1)
        {
            result = "ikinci sayı büyüktür.";
        }
        else{
            result = "sayılar eşittir.";
        }

        System.Console.WriteLine(result);
    }
}
