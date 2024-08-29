namespace Soru8;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("0-6 arasında bir sayı giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        string result;

        if (sayi <=6 && sayi >=0)
        {
            switch (sayi)
            {
                case 0 :
                    result = "nokta";
                    break;
                case 1:
                    result = "üçgen";
                    break;
                case 2:
                    result = "kare";
                    break;
                case 3:
                    result = "daire";
                    break;
                case 4:
                    result = "dikdörtgen";
                    break;
                case 5:
                    result = "beşgen";
                    break;
                case 6:
                    result = "yamuk";
                    break;

                default:
                    result = "Invalid value";
                    break;
            }
            System.Console.WriteLine($"You entered {result}.");
        }
        else
        {
            System.Console.WriteLine("YOu entered invalid value!");
        }
    }
}
