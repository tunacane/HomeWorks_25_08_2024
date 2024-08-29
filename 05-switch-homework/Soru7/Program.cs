namespace Soru7;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("1-5 arası bir sayı giriniz: ");
        int number = Convert.ToInt32(Console.ReadLine());

        string moneyType;

        if (number <=5 && number >= 1)
        {
            switch (number)
            {
                case 1 :
                    moneyType = "1 KR";
                    break;
                case 2 : 
                    moneyType = "5 KR";
                    break;
                case 3 :
                    moneyType = "10 KR";
                    break;
                case 4 :
                    moneyType = "25 KR";
                    break;
                case 5 :
                    moneyType = "50 KR";
                    break;

                default:
                    moneyType = "Invalid value";
                    break;
            }
            System.Console.WriteLine($"You entered {moneyType}");
        }
        else
        {
            System.Console.WriteLine("Invalid value");
        }


    }
}
