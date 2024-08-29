namespace Soru5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir sayı giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
       
        string result ="";

        switch (sayi)
        {
            case 12:
            case 1:
            case 2:
                result= "Season is Winter";
                break;
            case 3:
            case 4:
            case 5:
                result = "Season is Spring";
                break;
            
            case 6:
            case 7:
            case 8:
                result = "Season is Summer";
                break;
            case 9:
            case 10:
            case 11:
                result = "Season is Autumn";
                break;

            default:
                result = "Invalid value!";
                break;
        }
        System.Console.WriteLine(result);
    }
}
