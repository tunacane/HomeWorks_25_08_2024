namespace Soru3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir tarih giriniz: ");

        DateTime date = Convert.ToDateTime(Console.ReadLine());

        System.Console.WriteLine(date.AddDays(52));
    }
}
