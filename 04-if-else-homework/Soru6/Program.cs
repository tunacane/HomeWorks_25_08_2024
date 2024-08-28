using System.Drawing;

namespace Soru6;

class Program
{
    static void Main(string[] args)
    {
       System.Console.WriteLine("Sınav puanınızı giriniz: ");
       int point = Convert.ToInt32(Console.ReadLine());
       
        string note="";

       System.Console.WriteLine("Devamsızlık gününüzü yazınız: ");
        int hol = Convert.ToInt32(Console.ReadLine());

       

        if (point >= 90)
       {
           note = "AA";
       }
       else if (point >= 85)
       {
          note = "BA";
        }
        else if (point >= 80)
        {
            note = "BB";
        }
        else if (point >= 70)
        {
            note = "CB";
        }
        else if (point >= 60 )
        {
            note = "CC";
        }
        else if (point >= 55)
        {
            note = "DC";
        }
        else if (point >= 50)
        {
            note = "DD";
        }
        else if (point >= 40)
        {
            note = "FD";
        }
        else if (point >= 0)
        {
            note = "FF";
        }
       System.Console.WriteLine($"Notunuz: {note} ");

        if (note == "AA" || note == "BA" || note == "BB" ||  note == "CB" || note == "CC")
        {
            System.Console.WriteLine("Notunuz yeterli");
        }
        else
        {
            System.Console.WriteLine("Notunuz yetersiz");
        }
            if (hol < 20)
            {
                System.Console.WriteLine("Devam hakkınız bulunuyor.");
            }
            else
            {
                System.Console.WriteLine("Devamsızlıktan kaldınız");
            }
        
    }
}
