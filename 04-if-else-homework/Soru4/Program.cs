namespace Soru4;

class Program
{
    static void Main(string[] args)
    {
      System.Console.WriteLine("Bir tarih giriniz: ");
      int year = Convert.ToInt32(Console.ReadLine());

      bool IsLeapYear  = DateTime.IsLeapYear(year);
     
      if (IsLeapYear)
      {
        System.Console.WriteLine($"{year} artık yıldır.");
      }
      else{
            System.Console.WriteLine($"{year} artık yıl değildir.");
        }


    }
}
