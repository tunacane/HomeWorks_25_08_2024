namespace Soru3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir harf giriniz: ");
        char letter = Convert.ToChar(Console.ReadLine());

       bool isVowel =  (letter == 'a') || (letter =='e') || (letter =='ı') ||  (letter == 'i') ||  (letter == 'o' )|| (letter == 'ö' )||  (letter =='u' )||  (letter == 'ü');

       if (isVowel)
       {
        System.Console.WriteLine($"{letter}  sesli bir harftir.");
       }
       else
       {
        System.Console.WriteLine($"{letter} sessiz bir harftir. ");
       }



    }
}
