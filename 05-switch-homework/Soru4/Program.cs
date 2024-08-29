using System.Reflection.PortableExecutable;
using System.Threading.Tasks.Dataflow;

namespace Soru;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir harf giriniz: ");
        string letter = Console.ReadLine().ToLower();

        string result="";

        if (letter.Length == 1 && char.IsLetter(letter[0]))
        {

            switch (letter)
            {
                case "a":
                case "e":
                case "ı" :                 
                case "i":      
                case "o":       
                case "ö":    
                case "u":       
                case "ü":          
                    result = "letter is vowel.";
                    break;

                default:

                    result = "letter is not vowel";
                    break;
            }
            System.Console.WriteLine(result);
        }
        else
        {
            System.Console.WriteLine("Geçersiz veri girdiniz.");
        }

    }
}
