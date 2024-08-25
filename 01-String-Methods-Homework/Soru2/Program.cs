namespace Soru2;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Bir cümle giriniz: ");
        string sentence = Console.ReadLine();
       // string sentence = "İkinci sorudaki kelime sayısını bulunuz";

        System.Console.Write($"Büyük harf: {sentence.ToUpper()}\nKüçük harf: {sentence.ToLower()}");
       
    }
}
