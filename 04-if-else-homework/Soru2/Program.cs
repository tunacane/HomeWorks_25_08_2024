namespace Soru2;

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

        int enBuyuk, enKucuk, orta;

        if (num1 > num2 && num1 > num3)
        {
            enBuyuk = num1;
            if (num2 > num3)
            {
                orta = num2;
                enKucuk = num3;
            }
            else{
                orta = num3;
                enKucuk = num2;
            }
        }
        else if (num2 > num1 && num2 > num3)
        {
            enBuyuk = num2;
            if (num1 >num3)
            {
                orta = num1;
                enKucuk = num3;
            }
            else
            {
                orta = num3;
                enKucuk = num1;
            }
            
        }
        else
        {
            enBuyuk = num3;

            if (num2 > num1)
            {
                orta = num2;
                enKucuk = num1;
            }
            else
            {
                orta = num1;
                enKucuk = num2;
            }
        }

        System.Console.WriteLine($"Büyükten küçüğe sıralanmış sayılar:  {enBuyuk} , {orta}, {enKucuk}");
    }
}
