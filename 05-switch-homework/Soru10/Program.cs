namespace Soru10;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir işlem giriniz: ");
        string islem = Console.ReadLine();

        string result;

        switch (islem)
        {
            case "+":
                result ="toplam";
                break;
            case "-":
                result ="fark";
                break;
            case "*":
                result ="çarpmaım";
                break;
            case "/":
                result ="bölüm";
                break;
            case "&":
                result = "mod";
                break;

            default:
                result = "Geçersiz veri girdiniz";
                break;
        }
        System.Console.WriteLine($"Girdiğiniz {islem} işaretinin karşılığı { result}'a eşittir.");
    }
}
