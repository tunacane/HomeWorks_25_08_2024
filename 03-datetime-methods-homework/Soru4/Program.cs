namespace Soru4;

class Program
{
    static void Main(string[] args)
    {
        DateTime date1 = new DateTime(1987 , 12 ,14);
        DateTime date2 = new DateTime(1992, 11, 13);

        TimeSpan newDate = (date2 - date1);

    
        System.Console.WriteLine(Math.Abs(newDate.TotalDays));

    }
}
