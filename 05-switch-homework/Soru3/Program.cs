namespace Soru3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Birinci sayıyı giriniz: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("İkinci sayıyı giriniz: ");
       double sayi2 = Convert.ToDouble(Console.ReadLine());

        System.Console.WriteLine("Lütfen işlemi giriniz: ");
        string islem = Console.ReadLine();

        double toplam = sayi1 +sayi2;
        double fark = sayi1 -sayi2;
        double carpim = sayi1*sayi2;
        double bolme = sayi1/sayi2;

        double result =0;
        
        if (true)
        {
            switch (islem)
            {
                case "+":
                    result= toplam;
                    break;
                case "-":
                    result = fark;
                    break;
                case "*":
                    result = carpim;
                    break;

                default:
                    result = bolme;
                    break;
            }
            System.Console.WriteLine($"{sayi1} {islem} {sayi2} = {result}");
        }
        else{
            System.Console.WriteLine("Geçersiz veri girdiniz!");
        }
    }
}
