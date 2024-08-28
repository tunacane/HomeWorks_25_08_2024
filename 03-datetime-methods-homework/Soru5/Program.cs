namespace Soru5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir tarih giriniz: ");
        DateTime date = Convert.ToDateTime(Console.ReadLine());

        int dayOfDate = date.DayOfYear;

        System.Console.WriteLine(dayOfDate);


    }
}
