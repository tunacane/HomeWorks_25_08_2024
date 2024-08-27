namespace Soru2;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Birinci sayıyı giriniz: ");
        int number1 = int.Parse(Console.ReadLine());

        System.Console.WriteLine("İkinci sayıyı giriniz");
        int number2 = int.Parse(Console.ReadLine());

        if (number1 > number2){
            System.Console.WriteLine("Birinci sayı büyüktür");
        }

        else{
            System.Console.WriteLine("İkinci sayı büyüktür");
        }
       
            
        }


    }

