namespace Soru6;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Sınav notunuzu giriniz: ");
        int point = Convert.ToInt32(Console.ReadLine());
        string result;

        if (point >=30 && point <= 100)
        {
            switch (point)
            {
                case < 45:
                    result = "F";
                    break;
                case < 65:
                    result = "D";
                    break;
                case < 75:
                    result = "C";
                    break;
                case < 85:
                    result = "B";
                    break;
                case < 100:
                    result = "A";
                    break;
            
                default:
                    result = "Invlaid value";
                    break;
            }
            System.Console.WriteLine($"Your point is {result}");
        }
        else
        {
            System.Console.WriteLine("You failed!");
        }
    }
}
