namespace Soru9;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir tarih giriniz: ");

        DateTime date1 = Convert.ToDateTime(Console.ReadLine());

        System.Console.WriteLine("İkinci tarihi giriniz: ");
        DateTime date2 = Convert.ToDateTime(Console.ReadLine());

        if (date1 > date2)
        {
            System.Console.WriteLine($"{date1} {date2} tarihinden daha ileri bir tarihtir");
        }
        else if (date2 > date1)
        {
            System.Console.WriteLine($"{date2} {date1} tarihinden daha ileri bir tarihtir");
        }
        else{
            System.Console.WriteLine($"{date1} ve {date2} tarihleri aynı gündür");
        }
       
    }
}
