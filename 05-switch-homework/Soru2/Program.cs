namespace Soru2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1-12 arasında bir sayı giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        string month = "";

        if (sayi>=1 && sayi <= 12)
        {
            switch (sayi)
            {
                case 1:
                    month = "January";
                    break;
                case 2:
                    month = "February";
                    break;
                case 3:
                    month = "March";
                    break;
                case 4:
                    month = "April";
                    break;
                case 5:
                    month = "May";
                    break;
                case 6:
                    month = "June";
                    break;
                case 7:
                    month = "July";
                    break;
                case 8:
                    month = "August";
                    break;
                case 9:
                    month = "September";
                    break;
                case 10:
                    month = "October";
                    break;
                case 11:
                    month = "November";
                    break;

                default:
                    System.Console.WriteLine("December");
                    break;
            }

            System.Console.WriteLine($"Aylardan {month}.");
        }
        else
        {
            System.Console.WriteLine("Geçersiz veri girdiniz.");
        }

      
     
    }
}
