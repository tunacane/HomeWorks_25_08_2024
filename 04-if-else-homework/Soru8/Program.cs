namespace Soru8;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir sayı giriniz: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        if (num1 %3 ==0 && num1 %5 ==0)
        {
            System.Console.WriteLine(num1 +": 3 ve 5 ile kalansız bölünebilir.");
        }
        else
        {
            System.Console.WriteLine(num1+ ": 3 ve 5 ile kalansız bölünemez. ");
        }
    }
}
