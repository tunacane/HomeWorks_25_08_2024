namespace Soru6;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Bir tarih giriniz: ");

        int date = Convert.ToInt32(Console.ReadLine());

        bool leapYear =  DateTime.IsLeapYear(date);

        System.Console.WriteLine(leapYear);
    }
}
