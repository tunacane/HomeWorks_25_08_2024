namespace Soru1;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Bir cümle girinizi: ");

        string cumle1 = Console.ReadLine();

        

    //  string cumle1 = "Birinci sorudaki kelime sayısını bulunuz";
       string[] word = cumle1.Split(" "); 
       
      int wordCount = word.Length;
      System.Console.WriteLine(wordCount);

   
    }
}
