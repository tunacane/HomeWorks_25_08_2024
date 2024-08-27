namespace Soru3;

class Program
{
    static void Main(string[] args)
    {
       System.Console.WriteLine("Bir cümle giriniz: ");
       string sentence = Console.ReadLine();

       System.Console.WriteLine("Aranacak kelimeyi giriniz: ");
       string searchWord = Console.ReadLine();

       //char[] seperators = {' ', ' '};

       string[] word = sentence.ToLower().Split({searchWord});

       int wordAccount = searchWord;
       System.Console.WriteLine(wordAccount);




   
   
    

    

    }
}
