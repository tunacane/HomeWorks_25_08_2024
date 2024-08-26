namespace Soru5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir metin giriniz: ");
        string text = Console.ReadLine();

        System.Console.WriteLine("İkinci metni giriniz: ");
        string newText = Console.ReadLine();

        if (text.Contains(newText.ToLower()))
        {
           int index = text.IndexOf(newText);
           System.Console.WriteLine(index);
        }
        else
        {
            System.Console.WriteLine("İlgili metin bulunamamıştır");
        }
    }
}
