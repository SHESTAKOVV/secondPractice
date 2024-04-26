namespace _1;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Введите драгоценности: ");
        string j = Console.ReadLine();

        Console.WriteLine("Введите камни: ");
        string s = Console.ReadLine();

        foreach (char valuable in j)
        {
            int count = 0;
            foreach (char notValuable in s)
            {
                if (valuable == notValuable)
                {
                    count++;
                    Console.WriteLine($"\nКамень { valuable } - является драгоценным.");
                }
            }
        }
    }
}