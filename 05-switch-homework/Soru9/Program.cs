namespace Soru9;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1-5 arasında bir sayı giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        

        string adjName;

        if (sayi<=5 && sayi>=1)
        {
            switch (sayi)
            {
                case 1:
                    adjName ="birinci";
                    break;
                case 2:
                    adjName ="ikinci";
                    break;
                case 3:
                    adjName ="üçüncü";
                    break;
                case 4:
                    adjName ="dördüncü";
                    break;
                
                default:
                    adjName = "beşinci";
                    break;

            }
            System.Console.WriteLine($"{sayi} = {adjName}");
        }
        else
        {
            System.Console.WriteLine("Geçersiz veri girdiniz");
        }
    }
}
