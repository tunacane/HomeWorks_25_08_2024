using System.Runtime.InteropServices;

namespace Soru4;

class Program
{
    static void Main(string[] args)

    {
        System.Console.WriteLine("Bir cümle giriniz: ");
        string sentence = Console.ReadLine();
      
       //string sentence= " Acunmedya Akademi 10.Dönem Backend ";

       string newSentence = sentence.Trim();
       System.Console.WriteLine($"Eski cümle: {sentence}\nYeni cümle: {newSentence}");

      System.Console.WriteLine(sentence.Length);
    System.Console.WriteLine(newSentence.Length);
    }

}
